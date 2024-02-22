namespace ADBoyaSU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            selectPics = new Label();
            openFilePath = new TextBox();
            browsImages = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            okButton = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dontConsiderThese = new Label();
            textBox6 = new TextBox();
            seePreviousFile = new Button();
            seeNextFile = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            button5 = new Button();
            checkBox1 = new CheckBox();
            label10 = new Label();
            textBox8 = new TextBox();
            imageList = new ImageList(components);
            label12 = new Label();
            helpToolStripMenuItem = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            harHarHarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // selectPics
            // 
            selectPics.Font = new Font("Segoe UI", 12F);
            selectPics.ForeColor = Color.Black;
            selectPics.Location = new Point(33, 38);
            selectPics.Name = "selectPics";
            selectPics.Size = new Size(100, 20);
            selectPics.TabIndex = 0;
            selectPics.Text = "Əkızlərin Seç";
            selectPics.Click += label1_Click;
            // 
            // openFilePath
            // 
            openFilePath.AllowDrop = true;
            openFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openFilePath.Location = new Point(33, 74);
            openFilePath.Name = "openFilePath";
            openFilePath.Size = new Size(680, 23);
            openFilePath.TabIndex = 999;
            openFilePath.TextChanged += openFilePath_TextChanged;
            // 
            // browsImages
            // 
            browsImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browsImages.BackColor = Color.DeepSkyBlue;
            browsImages.FlatAppearance.BorderSize = 0;
            browsImages.FlatStyle = FlatStyle.Flat;
            browsImages.Font = new Font("Segoe UI", 12F);
            browsImages.Location = new Point(725, 67);
            browsImages.Name = "browsImages";
            browsImages.Size = new Size(90, 35);
            browsImages.TabIndex = 1;
            browsImages.Text = "Gəz";
            browsImages.UseVisualStyleBackColor = false;
            browsImages.Click += browsImages_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Location = new Point(432, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(62, 115);
            label1.Name = "label1";
            label1.Size = new Size(700, 1);
            label1.TabIndex = 999;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(62, 395);
            label2.Name = "label2";
            label2.Size = new Size(700, 1);
            label2.TabIndex = 999;
            label2.Click += label1_Click_1;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.BackColor = Color.Chartreuse;
            okButton.FlatAppearance.BorderColor = Color.Chartreuse;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Segoe UI", 11F);
            okButton.Location = new Point(725, 486);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 45);
            okButton.TabIndex = 1000;
            okButton.Text = "Oldu, Yaxçı";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.OrangeRed;
            button3.FlatAppearance.BorderColor = Color.OrangeRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(615, 486);
            button3.Name = "button3";
            button3.Size = new Size(105, 45);
            button3.TabIndex = 1000;
            button3.Text = "Bırax, İstəmır";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Seçimlər";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(62, 172);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 0;
            label4.Text = "Başlamak Yerı:";
            label4.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 23);
            textBox2.TabIndex = 1001;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(302, 175);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 0;
            label5.Text = "X";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(316, 175);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 0;
            label6.Text = "Y";
            label6.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(47, 23);
            textBox3.TabIndex = 1001;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(62, 212);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 0;
            label7.Text = "Sıraların Sayısı:";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(62, 252);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 0;
            label8.Text = "Sütunların Sayısı:";
            label8.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(295, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(47, 23);
            textBox4.TabIndex = 1001;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(295, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(47, 23);
            textBox5.TabIndex = 1001;
            // 
            // dontConsiderThese
            // 
            dontConsiderThese.Font = new Font("Segoe UI", 12F);
            dontConsiderThese.ForeColor = Color.Black;
            dontConsiderThese.Location = new Point(62, 332);
            dontConsiderThese.Name = "dontConsiderThese";
            dontConsiderThese.Size = new Size(132, 20);
            dontConsiderThese.TabIndex = 0;
            dontConsiderThese.Text = "Bıları Gözə Alma:";
            dontConsiderThese.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(249, 332);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(137, 23);
            textBox6.TabIndex = 1001;
            // 
            // seePreviousFile
            // 
            seePreviousFile.Anchor = AnchorStyles.Right;
            seePreviousFile.Enabled = false;
            seePreviousFile.Location = new Point(603, 356);
            seePreviousFile.Name = "seePreviousFile";
            seePreviousFile.Size = new Size(22, 23);
            seePreviousFile.TabIndex = 1002;
            seePreviousFile.Text = "<";
            seePreviousFile.UseVisualStyleBackColor = true;
            seePreviousFile.Click += seePreviousFile_Click;
            // 
            // seeNextFile
            // 
            seeNextFile.Anchor = AnchorStyles.Right;
            seeNextFile.Enabled = false;
            seeNextFile.Location = new Point(637, 356);
            seeNextFile.Name = "seeNextFile";
            seeNextFile.Size = new Size(22, 23);
            seeNextFile.TabIndex = 1002;
            seeNextFile.Text = ">";
            seeNextFile.UseVisualStyleBackColor = true;
            seeNextFile.Click += seeNextFile_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 409);
            label9.Name = "label9";
            label9.Size = new Size(172, 20);
            label9.TabIndex = 0;
            label9.Text = "Sonucları Bırda Saxla";
            label9.Click += label1_Click;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(33, 445);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(680, 23);
            textBox7.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.DeepSkyBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(725, 438);
            button5.Name = "button5";
            button5.Size = new Size(90, 35);
            button5.TabIndex = 2;
            button5.Text = "Gəz";
            button5.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(109, 139);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 1004;
            checkBox1.Text = "Əkızlərı Boazart";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(62, 292);
            label10.Name = "label10";
            label10.Size = new Size(183, 24);
            label10.TabIndex = 0;
            label10.Text = "Dörtbıcaqların Böüklügü:";
            label10.Click += label1_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(295, 292);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(47, 23);
            textBox8.TabIndex = 1001;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(16, 16);
            imageList.TransparentColor = Color.Transparent;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(626, 360);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 1006;
            label12.Text = "|";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { licenceToolStripMenuItem, yardımToolStripMenuItem, harHarHarToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(56, 20);
            helpToolStripMenuItem.Text = "Yardım";
            // 
            // licenceToolStripMenuItem
            // 
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            licenceToolStripMenuItem.Size = new Size(147, 22);
            licenceToolStripMenuItem.Text = "Birincı Yardım";
            licenceToolStripMenuItem.Click += licenceToolStripMenuItem_Click;
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(147, 22);
            yardımToolStripMenuItem.Text = "Ikincı Yardım";
            // 
            // harHarHarToolStripMenuItem
            // 
            harHarHarToolStripMenuItem.Name = "harHarHarToolStripMenuItem";
            harHarHarToolStripMenuItem.Size = new Size(147, 22);
            harHarHarToolStripMenuItem.Text = "Har Har Har";
            // 
            // menuStrip1
            // 
            menuStrip1.Enabled = false;
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(843, 24);
            menuStrip1.TabIndex = 1003;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.Location = new Point(348, 212);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 1007;
            button1.Text = "çox";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(348, 252);
            button2.Name = "button2";
            button2.Size = new Size(38, 23);
            button2.TabIndex = 1007;
            button2.Text = "çox";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(348, 292);
            button4.Name = "button4";
            button4.Size = new Size(38, 23);
            button4.TabIndex = 1007;
            button4.Text = "çox";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(249, 212);
            button6.Name = "button6";
            button6.Size = new Size(38, 23);
            button6.TabIndex = 1007;
            button6.Text = "az";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(249, 252);
            button7.Name = "button7";
            button7.Size = new Size(38, 23);
            button7.TabIndex = 1007;
            button7.Text = "az";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(249, 293);
            button8.Name = "button8";
            button8.Size = new Size(38, 23);
            button8.TabIndex = 1007;
            button8.Text = "az";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(843, 548);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(checkBox1);
            Controls.Add(seeNextFile);
            Controls.Add(seePreviousFile);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(textBox8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(okButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(browsImages);
            Controls.Add(textBox7);
            Controls.Add(openFilePath);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dontConsiderThese);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(selectPics);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectPics;
        private TextBox openFilePath;
        private Label label1;
        private Label label2;
        private Button okButton;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label dontConsiderThese;
        private TextBox textBox6;
        private Button seePreviousFile;
        private Button seeNextFile;
        private Label label9;
        private TextBox textBox7;
        private Button button5;
        private CheckBox checkBox1;
        private Label label10;
        private TextBox textBox8;
        public Button browsImages;
        private ImageList imageList;
        private Label label12;
        public PictureBox pictureBox1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem harHarHarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
