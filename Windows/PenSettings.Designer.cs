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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenSettings));
            description = new Label();
            browsImages = new Button();
            SuspendLayout();
            // 
            // description
            // 
            resources.ApplyResources(description, "description");
            description.Name = "description";
            // 
            // browsImages
            // 
            resources.ApplyResources(browsImages, "browsImages");
            browsImages.BackColor = Color.DeepSkyBlue;
            browsImages.FlatAppearance.BorderSize = 0;
            browsImages.Name = "browsImages";
            browsImages.UseVisualStyleBackColor = false;
            browsImages.Click += browsImages_Click;
            // 
            // PenSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(browsImages);
            Controls.Add(description);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PenSettings";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label description;
        public Button browsImages;
    }
}