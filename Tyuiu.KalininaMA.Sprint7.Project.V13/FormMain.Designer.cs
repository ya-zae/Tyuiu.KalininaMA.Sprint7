namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonInfo_KMA = new Button();
            buttonHelp_KMA = new Button();
            buttonChart_KMA = new Button();
            buttonReturn_KMA = new Button();
            buttonOpenFile_KMA = new Button();
            panel2 = new Panel();
            groupBoxMain_KMA = new GroupBox();
            groupBox3 = new GroupBox();
            buttonDelete_KMA = new Button();
            labelDelete_KMA = new Label();
            textBoxDelete_KMA = new TextBox();
            groupBoxNewCountry_KMA = new GroupBox();
            buttonAccept_KMA = new Button();
            label1Dvelop_KMA = new Label();
            labelAddPopulation_KMA = new Label();
            label5 = new Label();
            labelAddNation_KMA = new Label();
            labelAddArea_KMA = new Label();
            labelAddCapital_KMA = new Label();
            labelNameCountry_KMA = new Label();
            radioButtonNo_KMA = new RadioButton();
            radioButtonYes_KMA = new RadioButton();
            textBoxAddArea_KMA = new TextBox();
            textBoxAddPopulation_KMA = new TextBox();
            textBoxAddNational_KMA = new TextBox();
            textBoxAddCapital_KMA = new TextBox();
            textBoxAddCountry_KMA = new TextBox();
            groupBox1 = new GroupBox();
            Columns_KMA = new Label();
            labelWhatSearch_KMA = new Label();
            buttonSearch_KMA = new Button();
            textBoxColumns_KMA = new TextBox();
            textBoxWhatSearch_KMA = new TextBox();
            panel3 = new Panel();
            groupBoxSort_KMA = new GroupBox();
            ToolStripMenuItemSortMin_KMA = new Button();
            ToolStripMenuItemSortMax_KMA = new Button();
            menuStrip1 = new MenuStrip();
            dataGridViewResult_KMA = new DataGridView();
            openFileDialogMain_KMA = new OpenFileDialog();
            saveFileDialogMain_KMA = new SaveFileDialog();
            toolTip_KMA = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxMain_KMA.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxNewCountry_KMA.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxSort_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(buttonInfo_KMA);
            panel1.Controls.Add(buttonHelp_KMA);
            panel1.Controls.Add(buttonChart_KMA);
            panel1.Controls.Add(buttonReturn_KMA);
            panel1.Controls.Add(buttonOpenFile_KMA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 79);
            panel1.TabIndex = 0;
            // 
            // buttonInfo_KMA
            // 
            buttonInfo_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_KMA.Image = (Image)resources.GetObject("buttonInfo_KMA.Image");
            buttonInfo_KMA.Location = new Point(863, 20);
            buttonInfo_KMA.Name = "buttonInfo_KMA";
            buttonInfo_KMA.Size = new Size(50, 45);
            buttonInfo_KMA.TabIndex = 4;
            toolTip_KMA.SetToolTip(buttonInfo_KMA, "информация о разработчике");
            buttonInfo_KMA.UseVisualStyleBackColor = true;
            buttonInfo_KMA.Click += buttonInfo_KMA_Click;
            buttonInfo_KMA.MouseEnter += buttonInfo_KMA_MouseEnter;
            // 
            // buttonHelp_KMA
            // 
            buttonHelp_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KMA.Image = (Image)resources.GetObject("buttonHelp_KMA.Image");
            buttonHelp_KMA.Location = new Point(807, 20);
            buttonHelp_KMA.Name = "buttonHelp_KMA";
            buttonHelp_KMA.Size = new Size(50, 45);
            buttonHelp_KMA.TabIndex = 3;
            toolTip_KMA.SetToolTip(buttonHelp_KMA, "как пользоваться");
            buttonHelp_KMA.UseVisualStyleBackColor = true;
            buttonHelp_KMA.Click += buttonHelp_KMA_Click;
            buttonHelp_KMA.MouseEnter += buttonHelp_KMA_MouseEnter;
            // 
            // buttonChart_KMA
            // 
            buttonChart_KMA.Image = (Image)resources.GetObject("buttonChart_KMA.Image");
            buttonChart_KMA.Location = new Point(174, 12);
            buttonChart_KMA.Name = "buttonChart_KMA";
            buttonChart_KMA.Size = new Size(75, 61);
            buttonChart_KMA.TabIndex = 2;
            toolTip_KMA.SetToolTip(buttonChart_KMA, "открыть статистику");
            buttonChart_KMA.UseVisualStyleBackColor = true;
            buttonChart_KMA.Click += buttonChart_KMA_Click;
            buttonChart_KMA.MouseEnter += buttonChart_KMA_MouseEnter;
            // 
            // buttonReturn_KMA
            // 
            buttonReturn_KMA.Image = (Image)resources.GetObject("buttonReturn_KMA.Image");
            buttonReturn_KMA.Location = new Point(93, 12);
            buttonReturn_KMA.Name = "buttonReturn_KMA";
            buttonReturn_KMA.Size = new Size(75, 61);
            buttonReturn_KMA.TabIndex = 1;
            toolTip_KMA.SetToolTip(buttonReturn_KMA, "обновить таблицу");
            buttonReturn_KMA.UseVisualStyleBackColor = true;
            buttonReturn_KMA.Click += buttonReturn_KMA_Click;
            buttonReturn_KMA.MouseEnter += buttonReturn_KMA_MouseEnter;
            // 
            // buttonOpenFile_KMA
            // 
            buttonOpenFile_KMA.Image = (Image)resources.GetObject("buttonOpenFile_KMA.Image");
            buttonOpenFile_KMA.Location = new Point(12, 12);
            buttonOpenFile_KMA.Name = "buttonOpenFile_KMA";
            buttonOpenFile_KMA.Size = new Size(75, 61);
            buttonOpenFile_KMA.TabIndex = 0;
            toolTip_KMA.SetToolTip(buttonOpenFile_KMA, "добавьте файл\r\n");
            buttonOpenFile_KMA.UseVisualStyleBackColor = true;
            buttonOpenFile_KMA.Click += buttonOpenFile_KMA_Click;
            buttonOpenFile_KMA.MouseEnter += buttonOpenFile_KMA_MouseEnter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBoxMain_KMA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 487);
            panel2.TabIndex = 1;
            // 
            // groupBoxMain_KMA
            // 
            groupBoxMain_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMain_KMA.Controls.Add(groupBox3);
            groupBoxMain_KMA.Controls.Add(groupBoxNewCountry_KMA);
            groupBoxMain_KMA.Controls.Add(groupBox1);
            groupBoxMain_KMA.Location = new Point(12, 6);
            groupBoxMain_KMA.Name = "groupBoxMain_KMA";
            groupBoxMain_KMA.Size = new Size(333, 469);
            groupBoxMain_KMA.TabIndex = 0;
            groupBoxMain_KMA.TabStop = false;
            groupBoxMain_KMA.Text = "Главная";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(buttonDelete_KMA);
            groupBox3.Controls.Add(labelDelete_KMA);
            groupBox3.Controls.Add(textBoxDelete_KMA);
            groupBox3.Location = new Point(12, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 103);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Удаление стран:";
            // 
            // buttonDelete_KMA
            // 
            buttonDelete_KMA.Image = (Image)resources.GetObject("buttonDelete_KMA.Image");
            buttonDelete_KMA.Location = new Point(229, 41);
            buttonDelete_KMA.Name = "buttonDelete_KMA";
            buttonDelete_KMA.Size = new Size(74, 46);
            buttonDelete_KMA.TabIndex = 2;
            buttonDelete_KMA.UseVisualStyleBackColor = true;
            buttonDelete_KMA.Click += buttonDelete_KMA_Click;
            // 
            // labelDelete_KMA
            // 
            labelDelete_KMA.AutoSize = true;
            labelDelete_KMA.Location = new Point(10, 23);
            labelDelete_KMA.Name = "labelDelete_KMA";
            labelDelete_KMA.Size = new Size(105, 15);
            labelDelete_KMA.TabIndex = 1;
            labelDelete_KMA.Text = "Название страны:";
            // 
            // textBoxDelete_KMA
            // 
            textBoxDelete_KMA.Location = new Point(6, 41);
            textBoxDelete_KMA.Name = "textBoxDelete_KMA";
            textBoxDelete_KMA.Size = new Size(196, 23);
            textBoxDelete_KMA.TabIndex = 0;
            // 
            // groupBoxNewCountry_KMA
            // 
            groupBoxNewCountry_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxNewCountry_KMA.Controls.Add(buttonAccept_KMA);
            groupBoxNewCountry_KMA.Controls.Add(label1Dvelop_KMA);
            groupBoxNewCountry_KMA.Controls.Add(labelAddPopulation_KMA);
            groupBoxNewCountry_KMA.Controls.Add(label5);
            groupBoxNewCountry_KMA.Controls.Add(labelAddNation_KMA);
            groupBoxNewCountry_KMA.Controls.Add(labelAddArea_KMA);
            groupBoxNewCountry_KMA.Controls.Add(labelAddCapital_KMA);
            groupBoxNewCountry_KMA.Controls.Add(labelNameCountry_KMA);
            groupBoxNewCountry_KMA.Controls.Add(radioButtonNo_KMA);
            groupBoxNewCountry_KMA.Controls.Add(radioButtonYes_KMA);
            groupBoxNewCountry_KMA.Controls.Add(textBoxAddArea_KMA);
            groupBoxNewCountry_KMA.Controls.Add(textBoxAddPopulation_KMA);
            groupBoxNewCountry_KMA.Controls.Add(textBoxAddNational_KMA);
            groupBoxNewCountry_KMA.Controls.Add(textBoxAddCapital_KMA);
            groupBoxNewCountry_KMA.Controls.Add(textBoxAddCountry_KMA);
            groupBoxNewCountry_KMA.Location = new Point(11, 119);
            groupBoxNewCountry_KMA.Name = "groupBoxNewCountry_KMA";
            groupBoxNewCountry_KMA.Size = new Size(322, 235);
            groupBoxNewCountry_KMA.TabIndex = 1;
            groupBoxNewCountry_KMA.TabStop = false;
            groupBoxNewCountry_KMA.Text = "Добавление стран:";
            // 
            // buttonAccept_KMA
            // 
            buttonAccept_KMA.Image = (Image)resources.GetObject("buttonAccept_KMA.Image");
            buttonAccept_KMA.Location = new Point(230, 176);
            buttonAccept_KMA.Name = "buttonAccept_KMA";
            buttonAccept_KMA.Size = new Size(75, 43);
            buttonAccept_KMA.TabIndex = 14;
            buttonAccept_KMA.UseVisualStyleBackColor = true;
            buttonAccept_KMA.Click += buttonAccept_KMA_Click;
            // 
            // label1Dvelop_KMA
            // 
            label1Dvelop_KMA.AutoSize = true;
            label1Dvelop_KMA.Location = new Point(207, 108);
            label1Dvelop_KMA.Name = "label1Dvelop_KMA";
            label1Dvelop_KMA.Size = new Size(115, 15);
            label1Dvelop_KMA.TabIndex = 13;
            label1Dvelop_KMA.Text = "Развитая ли страна:";
            // 
            // labelAddPopulation_KMA
            // 
            labelAddPopulation_KMA.AutoSize = true;
            labelAddPopulation_KMA.Location = new Point(209, 63);
            labelAddPopulation_KMA.Name = "labelAddPopulation_KMA";
            labelAddPopulation_KMA.Size = new Size(96, 15);
            labelAddPopulation_KMA.TabIndex = 12;
            labelAddPopulation_KMA.Text = "Население, чел:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // labelAddNation_KMA
            // 
            labelAddNation_KMA.AutoSize = true;
            labelAddNation_KMA.Location = new Point(5, 63);
            labelAddNation_KMA.Name = "labelAddNation_KMA";
            labelAddNation_KMA.Size = new Size(198, 15);
            labelAddNation_KMA.TabIndex = 10;
            labelAddNation_KMA.Text = "Преобладающая национальность:";
            // 
            // labelAddArea_KMA
            // 
            labelAddArea_KMA.AutoSize = true;
            labelAddArea_KMA.Location = new Point(6, 108);
            labelAddArea_KMA.Name = "labelAddArea_KMA";
            labelAddArea_KMA.Size = new Size(165, 15);
            labelAddArea_KMA.TabIndex = 9;
            labelAddArea_KMA.Text = "Площадь территории, км^2:";
            labelAddArea_KMA.Click += labelAddArea_KMA_Click;
            // 
            // labelAddCapital_KMA
            // 
            labelAddCapital_KMA.AutoSize = true;
            labelAddCapital_KMA.Location = new Point(209, 19);
            labelAddCapital_KMA.Name = "labelAddCapital_KMA";
            labelAddCapital_KMA.Size = new Size(57, 15);
            labelAddCapital_KMA.TabIndex = 8;
            labelAddCapital_KMA.Text = "Столица:";
            // 
            // labelNameCountry_KMA
            // 
            labelNameCountry_KMA.AutoSize = true;
            labelNameCountry_KMA.Location = new Point(6, 19);
            labelNameCountry_KMA.Name = "labelNameCountry_KMA";
            labelNameCountry_KMA.Size = new Size(105, 15);
            labelNameCountry_KMA.TabIndex = 7;
            labelNameCountry_KMA.Text = "Название страны:";
            // 
            // radioButtonNo_KMA
            // 
            radioButtonNo_KMA.AutoSize = true;
            radioButtonNo_KMA.Location = new Point(217, 151);
            radioButtonNo_KMA.Name = "radioButtonNo_KMA";
            radioButtonNo_KMA.Size = new Size(45, 19);
            radioButtonNo_KMA.TabIndex = 6;
            radioButtonNo_KMA.TabStop = true;
            radioButtonNo_KMA.Text = "Нет";
            radioButtonNo_KMA.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes_KMA
            // 
            radioButtonYes_KMA.AutoSize = true;
            radioButtonYes_KMA.Location = new Point(217, 126);
            radioButtonYes_KMA.Name = "radioButtonYes_KMA";
            radioButtonYes_KMA.Size = new Size(39, 19);
            radioButtonYes_KMA.TabIndex = 5;
            radioButtonYes_KMA.TabStop = true;
            radioButtonYes_KMA.Text = "Да";
            radioButtonYes_KMA.UseVisualStyleBackColor = true;
            // 
            // textBoxAddArea_KMA
            // 
            textBoxAddArea_KMA.Location = new Point(6, 125);
            textBoxAddArea_KMA.Name = "textBoxAddArea_KMA";
            textBoxAddArea_KMA.Size = new Size(197, 23);
            textBoxAddArea_KMA.TabIndex = 4;
            // 
            // textBoxAddPopulation_KMA
            // 
            textBoxAddPopulation_KMA.Location = new Point(209, 81);
            textBoxAddPopulation_KMA.Name = "textBoxAddPopulation_KMA";
            textBoxAddPopulation_KMA.Size = new Size(107, 23);
            textBoxAddPopulation_KMA.TabIndex = 3;
            // 
            // textBoxAddNational_KMA
            // 
            textBoxAddNational_KMA.Location = new Point(6, 81);
            textBoxAddNational_KMA.Name = "textBoxAddNational_KMA";
            textBoxAddNational_KMA.Size = new Size(197, 23);
            textBoxAddNational_KMA.TabIndex = 2;
            textBoxAddNational_KMA.TextChanged += textBoxAddNational_KMA_TextChanged;
            // 
            // textBoxAddCapital_KMA
            // 
            textBoxAddCapital_KMA.Location = new Point(209, 37);
            textBoxAddCapital_KMA.Name = "textBoxAddCapital_KMA";
            textBoxAddCapital_KMA.Size = new Size(107, 23);
            textBoxAddCapital_KMA.TabIndex = 1;
            // 
            // textBoxAddCountry_KMA
            // 
            textBoxAddCountry_KMA.Location = new Point(5, 37);
            textBoxAddCountry_KMA.Name = "textBoxAddCountry_KMA";
            textBoxAddCountry_KMA.Size = new Size(198, 23);
            textBoxAddCountry_KMA.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(Columns_KMA);
            groupBox1.Controls.Add(labelWhatSearch_KMA);
            groupBox1.Controls.Add(buttonSearch_KMA);
            groupBox1.Controls.Add(textBoxColumns_KMA);
            groupBox1.Controls.Add(textBoxWhatSearch_KMA);
            groupBox1.Location = new Point(10, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск:";
            // 
            // Columns_KMA
            // 
            Columns_KMA.AutoSize = true;
            Columns_KMA.Location = new Point(112, 23);
            Columns_KMA.Name = "Columns_KMA";
            Columns_KMA.Size = new Size(96, 15);
            Columns_KMA.TabIndex = 4;
            Columns_KMA.Text = "Номер столбца:";
            // 
            // labelWhatSearch_KMA
            // 
            labelWhatSearch_KMA.AutoSize = true;
            labelWhatSearch_KMA.Location = new Point(6, 23);
            labelWhatSearch_KMA.Name = "labelWhatSearch_KMA";
            labelWhatSearch_KMA.Size = new Size(69, 15);
            labelWhatSearch_KMA.TabIndex = 3;
            labelWhatSearch_KMA.Text = "Что искать:";
            // 
            // buttonSearch_KMA
            // 
            buttonSearch_KMA.Location = new Point(218, 43);
            buttonSearch_KMA.Name = "buttonSearch_KMA";
            buttonSearch_KMA.Size = new Size(75, 23);
            buttonSearch_KMA.TabIndex = 2;
            buttonSearch_KMA.Text = "Поиск";
            buttonSearch_KMA.UseVisualStyleBackColor = true;
            buttonSearch_KMA.Click += buttonSearch_KMA_Click;
            // 
            // textBoxColumns_KMA
            // 
            textBoxColumns_KMA.Location = new Point(112, 44);
            textBoxColumns_KMA.Name = "textBoxColumns_KMA";
            textBoxColumns_KMA.Size = new Size(100, 23);
            textBoxColumns_KMA.TabIndex = 1;
            textBoxColumns_KMA.TextChanged += textBoxColumns_KMA_TextChanged;
            // 
            // textBoxWhatSearch_KMA
            // 
            textBoxWhatSearch_KMA.Location = new Point(6, 44);
            textBoxWhatSearch_KMA.Name = "textBoxWhatSearch_KMA";
            textBoxWhatSearch_KMA.Size = new Size(100, 23);
            textBoxWhatSearch_KMA.TabIndex = 0;
            textBoxWhatSearch_KMA.TextChanged += textBoxWhatSearch_KMA_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBoxSort_KMA);
            panel3.Controls.Add(dataGridViewResult_KMA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(351, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(586, 487);
            panel3.TabIndex = 2;
            // 
            // groupBoxSort_KMA
            // 
            groupBoxSort_KMA.Controls.Add(ToolStripMenuItemSortMin_KMA);
            groupBoxSort_KMA.Controls.Add(ToolStripMenuItemSortMax_KMA);
            groupBoxSort_KMA.Controls.Add(menuStrip1);
            groupBoxSort_KMA.Location = new Point(6, 6);
            groupBoxSort_KMA.Name = "groupBoxSort_KMA";
            groupBoxSort_KMA.Size = new Size(264, 48);
            groupBoxSort_KMA.TabIndex = 1;
            groupBoxSort_KMA.TabStop = false;
            groupBoxSort_KMA.Text = "Сортировка по численности населения";
            // 
            // ToolStripMenuItemSortMin_KMA
            // 
            ToolStripMenuItemSortMin_KMA.Location = new Point(140, 19);
            ToolStripMenuItemSortMin_KMA.Name = "ToolStripMenuItemSortMin_KMA";
            ToolStripMenuItemSortMin_KMA.Size = new Size(118, 23);
            ToolStripMenuItemSortMin_KMA.TabIndex = 2;
            ToolStripMenuItemSortMin_KMA.Text = "По убыванию";
            ToolStripMenuItemSortMin_KMA.UseVisualStyleBackColor = true;
            ToolStripMenuItemSortMin_KMA.Click += ToolStripMenuItemSortMin_KMA_Click;
            // 
            // ToolStripMenuItemSortMax_KMA
            // 
            ToolStripMenuItemSortMax_KMA.Location = new Point(10, 19);
            ToolStripMenuItemSortMax_KMA.Name = "ToolStripMenuItemSortMax_KMA";
            ToolStripMenuItemSortMax_KMA.Size = new Size(124, 23);
            ToolStripMenuItemSortMax_KMA.TabIndex = 0;
            ToolStripMenuItemSortMax_KMA.Text = "По возрастанию";
            ToolStripMenuItemSortMax_KMA.UseVisualStyleBackColor = true;
            ToolStripMenuItemSortMax_KMA.Click += ToolStripMenuItemSortMax_KMA_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(258, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataGridViewResult_KMA
            // 
            dataGridViewResult_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewResult_KMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KMA.Location = new Point(6, 60);
            dataGridViewResult_KMA.Name = "dataGridViewResult_KMA";
            dataGridViewResult_KMA.RowHeadersVisible = false;
            dataGridViewResult_KMA.Size = new Size(577, 415);
            dataGridViewResult_KMA.TabIndex = 0;
            // 
            // openFileDialogMain_KMA
            // 
            openFileDialogMain_KMA.FileName = "openFileDialogMain_KMA";
            // 
            // toolTip_KMA
            // 
            toolTip_KMA.IsBalloon = true;
            toolTip_KMA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 566);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxMain_KMA.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxNewCountry_KMA.ResumeLayout(false);
            groupBoxNewCountry_KMA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxSort_KMA.ResumeLayout(false);
            groupBoxSort_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonOpenFile_KMA;
        private Button buttonReturn_KMA;
        private Button buttonInfo_KMA;
        private Button buttonHelp_KMA;
        private Button buttonChart_KMA;
        private GroupBox groupBoxSort_KMA;
        private Button ToolStripMenuItemSortMin_KMA;
        private Button ToolStripMenuItemSortMax_KMA;
        private DataGridView dataGridViewResult_KMA;
        private GroupBox groupBoxMain_KMA;
        private GroupBox groupBox3;
        private GroupBox groupBoxNewCountry_KMA;
        private GroupBox groupBox1;
        private RadioButton radioButtonNo_KMA;
        private RadioButton radioButtonYes_KMA;
        private TextBox textBoxAddArea_KMA;
        private TextBox textBoxAddPopulation_KMA;
        private TextBox textBoxAddNational_KMA;
        private TextBox textBoxAddCapital_KMA;
        private TextBox textBoxAddCountry_KMA;
        private Button buttonSearch_KMA;
        private TextBox textBoxColumns_KMA;
        private TextBox textBoxWhatSearch_KMA;
        private Label labelAddPopulation_KMA;
        private Label label5;
        private Label labelAddNation_KMA;
        private Label labelAddArea_KMA;
        private Label labelAddCapital_KMA;
        private Label labelNameCountry_KMA;
        private Label label1Dvelop_KMA;
        private Button buttonAccept_KMA;
        private Label labelDelete_KMA;
        private TextBox textBoxDelete_KMA;
        private MenuStrip menuStrip1;
        private OpenFileDialog openFileDialogMain_KMA;
        private SaveFileDialog saveFileDialogMain_KMA;
        private ToolTip toolTip_KMA;
        private Button buttonDelete_KMA;
        private Label labelWhatSearch_KMA;
        private Label Columns_KMA;
    }
}