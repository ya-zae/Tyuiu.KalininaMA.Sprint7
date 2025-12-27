namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxHelp_KMA = new TextBox();
            buttonOk_KMA = new Button();
            SuspendLayout();
            // 
            // textBoxHelp_KMA
            // 
            textBoxHelp_KMA.BackColor = SystemColors.ControlLightLight;
            textBoxHelp_KMA.Location = new Point(12, 56);
            textBoxHelp_KMA.Multiline = true;
            textBoxHelp_KMA.Name = "textBoxHelp_KMA";
            textBoxHelp_KMA.ReadOnly = true;
            textBoxHelp_KMA.ScrollBars = ScrollBars.Vertical;
            textBoxHelp_KMA.Size = new Size(776, 332);
            textBoxHelp_KMA.TabIndex = 1;
            textBoxHelp_KMA.Text = resources.GetString("textBoxHelp_KMA.Text");
            // 
            // buttonOk_KMA
            // 
            buttonOk_KMA.Location = new Point(683, 414);
            buttonOk_KMA.Name = "buttonOk_KMA";
            buttonOk_KMA.Size = new Size(75, 23);
            buttonOk_KMA.TabIndex = 2;
            buttonOk_KMA.Text = "Ок";
            buttonOk_KMA.UseVisualStyleBackColor = true;
            buttonOk_KMA.Click += buttonOk_KMA_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk_KMA);
            Controls.Add(textBoxHelp_KMA);
            Name = "FormHelp";
            Text = "Помощь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxHelp_KMA;
        private Button buttonOk_KMA;
    }
}