namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxInfo = new TextBox();
            pictureBoxAvatar_KMA = new PictureBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KMA).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.Location = new Point(238, 12);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(301, 243);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            textBoxInfo.TextChanged += textBox1_TextChanged;
            // 
            // pictureBoxAvatar_KMA
            // 
            pictureBoxAvatar_KMA.Image = (Image)resources.GetObject("pictureBoxAvatar_KMA.Image");
            pictureBoxAvatar_KMA.Location = new Point(12, 12);
            pictureBoxAvatar_KMA.Name = "pictureBoxAvatar_KMA";
            pictureBoxAvatar_KMA.Size = new Size(220, 272);
            pictureBoxAvatar_KMA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_KMA.TabIndex = 1;
            pictureBoxAvatar_KMA.TabStop = false;
            pictureBoxAvatar_KMA.Click += pictureBoxAvatar_KMA_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(464, 261);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 296);
            Controls.Add(buttonOk);
            Controls.Add(pictureBoxAvatar_KMA);
            Controls.Add(textBoxInfo);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo;
        private PictureBox pictureBoxAvatar_KMA;
        private Button buttonOk;
    }
}