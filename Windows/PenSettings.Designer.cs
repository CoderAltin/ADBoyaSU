namespace ADBoyaSU
{
    partial class PenSettings
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
            browsImages = new Button();
            SuspendLayout();
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 12F);
            description.Location = new Point(55, 27);
            description.Name = "description";
            description.Size = new Size(402, 84);
            description.TabIndex = 3;
            description.Text = "Başda bir qələm qurabilmək yerı qoymağı düşünürdüm...\r\nAmma sora gördüm neynır.\r\n\r\nGavar gələn sürümlərdə.";
            description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // browsImages
            // 
            browsImages.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            browsImages.BackColor = Color.DeepSkyBlue;
            browsImages.FlatAppearance.BorderSize = 0;
            browsImages.FlatStyle = FlatStyle.Flat;
            browsImages.Font = new Font("Segoe UI", 12F);
            browsImages.Location = new Point(318, 159);
            browsImages.Name = "browsImages";
            browsImages.Size = new Size(184, 35);
            browsImages.TabIndex = 4;
            browsImages.Text = "Lap Da Düz Eləmişen";
            browsImages.UseVisualStyleBackColor = false;
            browsImages.Click += browsImages_Click;
            // 
            // PenSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 206);
            ControlBox = false;
            Controls.Add(browsImages);
            Controls.Add(description);
            MaximizeBox = false;
            MaximumSize = new Size(530, 245);
            MinimizeBox = false;
            MinimumSize = new Size(530, 245);
            Name = "PenSettings";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Qələmı Qur                                                                                                                                   -a Bilmə";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label description;
        public Button browsImages;
    }
}