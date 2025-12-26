namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartStats_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTip_KMA = new ToolTip(components);
            groupBoxStats_KMA = new GroupBox();
            buttonDevelop_KMA = new Button();
            buttonOk_KMA = new Button();
            buttonStats_KMA = new Button();
            ((System.ComponentModel.ISupportInitialize)chartStats_KMA).BeginInit();
            groupBoxStats_KMA.SuspendLayout();
            SuspendLayout();
            // 
            // chartStats_KMA
            // 
            chartStats_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            chartStats_KMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStats_KMA.Legends.Add(legend1);
            chartStats_KMA.Location = new Point(12, 12);
            chartStats_KMA.Name = "chartStats_KMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStats_KMA.Series.Add(series1);
            chartStats_KMA.Size = new Size(598, 467);
            chartStats_KMA.TabIndex = 0;
            chartStats_KMA.Text = "Страны";
            // 
            // groupBoxStats_KMA
            // 
            groupBoxStats_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStats_KMA.Controls.Add(buttonDevelop_KMA);
            groupBoxStats_KMA.Controls.Add(buttonOk_KMA);
            groupBoxStats_KMA.Controls.Add(buttonStats_KMA);
            groupBoxStats_KMA.Location = new Point(616, 12);
            groupBoxStats_KMA.Name = "groupBoxStats_KMA";
            groupBoxStats_KMA.Size = new Size(152, 467);
            groupBoxStats_KMA.TabIndex = 4;
            groupBoxStats_KMA.TabStop = false;
            groupBoxStats_KMA.Text = "Статистика";
            // 
            // buttonDevelop_KMA
            // 
            buttonDevelop_KMA.Location = new Point(6, 243);
            buttonDevelop_KMA.Name = "buttonDevelop_KMA";
            buttonDevelop_KMA.Size = new Size(131, 83);
            buttonDevelop_KMA.TabIndex = 5;
            buttonDevelop_KMA.Text = "Сколько существует развитых стран";
            buttonDevelop_KMA.UseVisualStyleBackColor = true;
            buttonDevelop_KMA.Click += buttonDevelop_KMA_Click;
            // 
            // buttonOk_KMA
            // 
            buttonOk_KMA.Location = new Point(6, 344);
            buttonOk_KMA.Name = "buttonOk_KMA";
            buttonOk_KMA.Size = new Size(75, 39);
            buttonOk_KMA.TabIndex = 4;
            buttonOk_KMA.Text = "Ок";
            buttonOk_KMA.UseVisualStyleBackColor = true;
            buttonOk_KMA.Click += buttonOk_KMA_Click;
            // 
            // buttonStats_KMA
            // 
            buttonStats_KMA.Location = new Point(6, 147);
            buttonStats_KMA.Name = "buttonStats_KMA";
            buttonStats_KMA.Size = new Size(131, 90);
            buttonStats_KMA.TabIndex = 3;
            buttonStats_KMA.Text = "Общая статистика";
            buttonStats_KMA.UseVisualStyleBackColor = true;
            buttonStats_KMA.Click += buttonStats_KMA_Click_1;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 493);
            Controls.Add(groupBoxStats_KMA);
            Controls.Add(chartStats_KMA);
            Name = "FormChart";
            Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)chartStats_KMA).EndInit();
            groupBoxStats_KMA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_KMA;
        private ToolTip toolTip_KMA;
        private GroupBox groupBoxStats_KMA;
        private Button buttonStats_KMA;
        private Button buttonOk_KMA;
        private Button buttonDevelop_KMA;
    }
}