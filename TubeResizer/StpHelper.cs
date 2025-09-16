using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TubeResizer
{
    public static class StpHelper
    {
        // Регулярка для строк именно вида:
        // LENGTH_MEASURE(<number>.),#<digits>)REPRESENTATION_ITEM('linear distance'));
        // Будем менять только такие совпадения (linear distance).
        private static readonly Regex LinearDistanceRegex = new Regex(
            @"LENGTH_MEASURE\(\s*([-+]?\d+(?:\.\d+)?)\.\s*\),#\d+\)REPRESENTATION_ITEM\('linear distance'\)\);",
            RegexOptions.Compiled);

        /// <summary>
        /// Создаёт файл на основе эталона и подменяет значение в LENGTH_MEASURE(... 'linear distance')
        /// во всех вхождениях этого шаблона.
        /// </summary>
        public static void CreateWithLengthMeasure(string templatePath, string outputPath, double newValue)
        {
            string text = File.ReadAllText(templatePath, DetectEncoding(templatePath));

            string formatted = newValue.ToString("0.########", CultureInfo.InvariantCulture); // число с точкой
            string replaced = LinearDistanceRegex.Replace(text, m =>
            {
                // Сохраняем всё как есть, кроме числа
                string whole = m.Value;
                // Меняем только группу числа
                string withNew = Regex.Replace(whole,
                    @"LENGTH_MEASURE\(\s*([-+]?\d+(?:\.\d+)?)\.",
                    $"LENGTH_MEASURE({formatted}.");
                return withNew;
            });

            File.WriteAllText(outputPath, replaced, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        }

        private static Encoding DetectEncoding(string path)
        {
            // Простая эвристика: если есть BOM — уважаем его; иначе читаем как UTF8 без BOM.
            using (var fs = File.OpenRead(path))
            {
                if (fs.Length >= 3)
                {
                    byte[] bom = new byte[3];
                    fs.Read(bom, 0, 3);
                    if (bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                        return new UTF8Encoding(true);
                }
            }
            return new UTF8Encoding(false);
        }
    }
}
