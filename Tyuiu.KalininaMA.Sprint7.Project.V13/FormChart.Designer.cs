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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartStats_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTip_KMA = new ToolTip(components);
            groupBoxStats_KMA = new GroupBox();
            buttonOk_KMA = new Button();
            buttonStats_KMA = new Button();
            buttonNational_KMA = new Button();
            ((System.ComponentModel.ISupportInitialize)chartStats_KMA).BeginInit();
            groupBoxStats_KMA.SuspendLayout();
            SuspendLayout();
            // 
            // chartStats_KMA
            // 
            chartStats_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            chartStats_KMA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStats_KMA.Legends.Add(legend2);
            chartStats_KMA.Location = new Point(12, 12);
            chartStats_KMA.Name = "chartStats_KMA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStats_KMA.Series.Add(series2);
            chartStats_KMA.Size = new Size(414, 294);
            chartStats_KMA.TabIndex = 0;
            chartStats_KMA.Text = "Страны";
            // 
            // groupBoxStats_KMA
            // 
            groupBoxStats_KMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStats_KMA.Controls.Add(buttonOk_KMA);
            groupBoxStats_KMA.Controls.Add(buttonStats_KMA);
            groupBoxStats_KMA.Controls.Add(buttonNational_KMA);
            groupBoxStats_KMA.Location = new Point(432, 12);
            groupBoxStats_KMA.Name = "groupBoxStats_KMA";
            groupBoxStats_KMA.Size = new Size(143, 294);
            groupBoxStats_KMA.TabIndex = 4;
            groupBoxStats_KMA.TabStop = false;
            groupBoxStats_KMA.Text = "Статистика";
            // 
            // buttonOk_KMA
            // 
            buttonOk_KMA.Location = new Point(62, 249);
            buttonOk_KMA.Name = "buttonOk_KMA";
            buttonOk_KMA.Size = new Size(75, 39);
            buttonOk_KMA.TabIndex = 4;
            buttonOk_KMA.Text = "Ок";
            buttonOk_KMA.UseVisualStyleBackColor = true;
            buttonOk_KMA.Click += buttonOk_KMA_Click;
            // 
            // buttonStats_KMA
            // 
            buttonStats_KMA.Location = new Point(6, 50);
            buttonStats_KMA.Name = "buttonStats_KMA";
            buttonStats_KMA.Size = new Size(131, 90);
            buttonStats_KMA.TabIndex = 3;
            buttonStats_KMA.Text = "Общая статистика";
            buttonStats_KMA.UseVisualStyleBackColor = true;
            buttonStats_KMA.Click += buttonStats_KMA_Click_1;
            // 
            // buttonNational_KMA
            // 
            buttonNational_KMA.Location = new Point(6, 146);
            buttonNational_KMA.Name = "buttonNational_KMA";
            buttonNational_KMA.Size = new Size(131, 91);
            buttonNational_KMA.TabIndex = 2;
            buttonNational_KMA.Text = "Преобладающие национальности";
            buttonNational_KMA.UseVisualStyleBackColor = true;
            buttonNational_KMA.Click += buttonNational_KMA_Click;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 320);
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
        private Button buttonNational_KMA;
        private Button buttonStats_KMA;
        private Button buttonOk_KMA;
    }
}