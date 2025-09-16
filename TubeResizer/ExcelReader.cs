using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace TubeResizer
{
    public static class ExcelReader
    {
        /// <summary>
        /// Читает числовые значения из одного столбца, от startCell до finishCell включительно.
        /// Пустые/текстовые/нечисловые — пропускает.
        /// Используется первый лист книги.
        /// </summary>
        public static List<double> ReadNumericColumn(string excelPath, string startCell, string finishCell)
        {
            var (startCol, startRow) = ParseCellAddress(startCell);
            var (finishCol, finishRow) = ParseCellAddress(finishCell);

            if (startCol != finishCol)
                throw new ArgumentException("Стартовая и финишная ячейки должны быть в одном столбце.");

            if (finishRow < startRow)
                throw new ArgumentException("Финишная ячейка выше стартовой — проверьте диапазон.");

            Excel.Application app = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            var result = new List<double>();

            try
            {
                app = new Excel.Application { Visible = false, DisplayAlerts = false };
                wb = app.Workbooks.Open(excelPath, ReadOnly: true);
                ws = (Excel.Worksheet)wb.Worksheets[1];

                for (int r = startRow; r <= finishRow; r++)
                {
                    var cell = (Excel.Range)ws.Cells[r, startCol];
                    object v = cell.Value2;

                    if (v == null) continue;

                    if (v is double d)
                    {
                        result.Add(d);
                        continue;
                    }

                    // Иногда Excel отдаёт строку
                    if (v is string s)
                    {
                        if (TryParseFlexible(s, out double parsed))
                            result.Add(parsed);
                    }
                }
            }
            finally
            {
                if (wb != null) wb.Close(false);
                if (app != null) app.Quit();

                Release(ws);
                Release(wb);
                Release(app);
            }

            return result;
        }

        private static bool TryParseFlexible(string text, out double value)
        {
            // Пытаемся и инвариантно (точка), и по текущей культуре (на случай запятых)
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return true;

            if (double.TryParse(text, NumberStyles.Float, CultureInfo.CurrentCulture, out value))
                return true;

            // Попытка нормализовать запятую к точке
            var norm = text.Replace(',', '.');
            if (double.TryParse(norm, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return true;

            value = 0;
            return false;
        }

        private static (int col, int row) ParseCellAddress(string addr)
        {
            if (string.IsNullOrWhiteSpace(addr))
                throw new ArgumentException("Пустой адрес ячейки.");

            addr = addr.Trim().ToUpperInvariant();

            int i = 0;
            while (i < addr.Length && char.IsLetter(addr[i])) i++;

            if (i == 0 || i == addr.Length)
                throw new ArgumentException($"Некорректный адрес ячейки: {addr}");

            string letters = addr.Substring(0, i);
            string digits = addr.Substring(i);

            int col = LettersToNumber(letters);
            if (!int.TryParse(digits, out int row) || row <= 0)
                throw new ArgumentException($"Некорректный адрес ячейки: {addr}");

            return (col, row);
        }

        private static int LettersToNumber(string letters)
        {
            int col = 0;
            foreach (char c in letters)
            {
                if (c < 'A' || c > 'Z') throw new ArgumentException($"Некорректная буква столбца: {c}");
                col = col * 26 + (c - 'A' + 1);
            }
            return col;
        }

        private static void Release(object com)
        {
            if (com == null) return;
            try { Marshal.FinalReleaseComObject(com); } catch { /* ignore */ }
        }
    }
}
