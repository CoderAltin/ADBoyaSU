namespace ADBoyaSU
{
    partial class popup
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
            description = new Label();
            SuspendLayout();
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 12F);
            description.Location = new Point(84, 21);
            description.Name = "description";
            description.Size = new Size(315, 168);
            description.TabIndex = 2;
            description.Text = "ADBoyaSU\r\n\r\nAltin'ın Düzəltdığı Boya Saymax Uyğulaması\r\n\r\n\r\n\r\nƏrşan-Altin\r\n2024 - OMA Oyunları (R)\r\n";
            description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // popup
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(484, 209);
            Controls.Add(description);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "popup";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bizə Görə";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox aboutUs;
        private Label description;
    }
}