using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubeResizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnBrowseStp.Click += BtnBrowseStp_Click;
            btnBrowseExcel.Click += BtnBrowseExcel_Click;
            btnBrowseOutput.Click += BtnBrowseOutput_Click;
            btnRun.Click += BtnRun_Click;
        }

        private void BtnBrowseStp_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title = "Выберите эталонный STP",
                Filter = "STEP files (*.stp;*.step)|*.stp;*.step|All files (*.*)|*.*"
            })
            {
                if (ofd.ShowDialog(this) == DialogResult.OK)
                    txtStpTemplate.Text = ofd.FileName;
            }
        }

        private void BtnBrowseExcel_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title = "Выберите Excel файл",
                Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*"
            })
            {
                if (ofd.ShowDialog(this) == DialogResult.OK)
                    txtExcelPath.Text = ofd.FileName;
            }
        }

        private void BtnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog { Description = "Выберите папку для сохранения STP" })
            {
                if (fbd.ShowDialog(this) == DialogResult.OK)
                    txtOutputFolder.Text = fbd.SelectedPath;
            }
        }

        private async void BtnRun_Click(object sender, EventArgs e)
        {
            try
            {
                btnRun.Enabled = false;

                // Валидация ввода
                var stpTemplate = txtStpTemplate.Text.Trim();
                var excelPath = txtExcelPath.Text.Trim();
                var outputFolder = txtOutputFolder.Text.Trim();
                var startCell = txtStartCell.Text.Trim();
                var finishCell = txtFinishCell.Text.Trim();

                if (!File.Exists(stpTemplate))
                    throw new FileNotFoundException("Не найден эталонный STP.", stpTemplate);
                if (!File.Exists(excelPath))
                    throw new FileNotFoundException("Не найден Excel файл.", excelPath);
                if (string.IsNullOrWhiteSpace(startCell) || string.IsNullOrWhiteSpace(finishCell))
                    throw new ArgumentException("Укажите стартовую и финишную ячейки.");
                if (string.IsNullOrWhiteSpace(outputFolder))
                    throw new ArgumentException("Укажите папку для сохранения.");
                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);

                // Чтение числовых значений из столбца диапазона
                var values = await Task.Run(() =>
                    ExcelReader.ReadNumericColumn(excelPath, startCell, finishCell));

                if (values.Count == 0)
                {
                    MessageBox.Show(this, "Числовых значений в указанном диапазоне не найдено.", "Готово",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ok = 0, fail = 0;
                foreach (var val in values)
                {
                    try
                    {
                        // Имя файла — по значению (без лишних точек)
                        var nameCore = val.ToString("0.########", CultureInfo.InvariantCulture).Replace('.', '_');
                        var outPath = Path.Combine(outputFolder, $"{nameCore}.stp");

                        // Создаём на основе эталона, заменяя LENGTH_MEASURE(...)
                        StpHelper.CreateWithLengthMeasure(stpTemplate, outPath, val);

                        ok++;
                    }
                    catch
                    {
                        fail++;
                    }
                }

                MessageBox.Show(this,
                    $"Готово.\nСоздано: {ok}\nОшибок: {fail}",
                    "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRun.Enabled = true;
            }
        }
    }
}
