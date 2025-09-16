namespace TubeResizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtStpTemplate = new System.Windows.Forms.TextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.btnBrowseStp = new System.Windows.Forms.Button();
            this.txtFinishCell = new System.Windows.Forms.TextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtStartCell = new System.Windows.Forms.TextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(83, 43);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Путь до Excel:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(25, 74);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(153, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Место для сохранения:";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(319, 129);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(161, 30);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Запустить процесс";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = false;
            // 
            // txtStpTemplate
            // 
            this.txtStpTemplate.Location = new System.Drawing.Point(183, 8);
            this.txtStpTemplate.Name = "txtStpTemplate";
            this.txtStpTemplate.Size = new System.Drawing.Size(259, 25);
            this.txtStpTemplate.TabIndex = 6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(18, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(159, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Путь до эталонного STP:";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(183, 39);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(259, 25);
            this.txtExcelPath.TabIndex = 6;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(183, 70);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(259, 25);
            this.txtOutputFolder.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 165);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 0);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 0);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBrowseExcel);
            this.panel2.Controls.Add(this.btnBrowseStp);
            this.panel2.Controls.Add(this.txtFinishCell);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.btnBrowseOutput);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.txtStartCell);
            this.panel2.Controls.Add(this.kryptonLabel4);
            this.panel2.Controls.Add(this.txtOutputFolder);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.txtExcelPath);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.txtStpTemplate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 165);
            this.panel2.TabIndex = 0;
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseExcel.BackgroundImage")));
            this.btnBrowseExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseExcel.FlatAppearance.BorderSize = 0;
            this.btnBrowseExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseExcel.Location = new System.Drawing.Point(443, 38);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(37, 25);
            this.btnBrowseExcel.TabIndex = 12;
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            // 
            // btnBrowseStp
            // 
            this.btnBrowseStp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseStp.BackgroundImage")));
            this.btnBrowseStp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseStp.FlatAppearance.BorderSize = 0;
            this.btnBrowseStp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseStp.Location = new System.Drawing.Point(443, 8);
            this.btnBrowseStp.Name = "btnBrowseStp";
            this.btnBrowseStp.Size = new System.Drawing.Size(37, 25);
            this.btnBrowseStp.TabIndex = 11;
            this.btnBrowseStp.UseVisualStyleBackColor = true;
            // 
            // txtFinishCell
            // 
            this.txtFinishCell.Location = new System.Drawing.Point(382, 101);
            this.txtFinishCell.Name = "txtFinishCell";
            this.txtFinishCell.Size = new System.Drawing.Size(98, 25);
            this.txtFinishCell.TabIndex = 10;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(297, 105);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(79, 21);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Финишная:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseOutput.BackgroundImage")));
            this.btnBrowseOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseOutput.FlatAppearance.BorderSize = 0;
            this.btnBrowseOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseOutput.Location = new System.Drawing.Point(443, 70);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(37, 25);
            this.btnBrowseOutput.TabIndex = 8;
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            // 
            // txtStartCell
            // 
            this.txtStartCell.Location = new System.Drawing.Point(183, 101);
            this.txtStartCell.Name = "txtStartCell";
            this.txtStartCell.Size = new System.Drawing.Size(97, 25);
            this.txtStartCell.TabIndex = 6;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(55, 105);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(122, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Стартовая ячейка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 165);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 204);
            this.MinimumSize = new System.Drawing.Size(510, 204);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tube Resizer";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtStpTemplate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStartCell;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtFinishCell;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.Button btnBrowseExcel;
        private System.Windows.Forms.Button btnBrowseStp;
    }
}

