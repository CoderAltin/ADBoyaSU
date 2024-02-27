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
            exitButton = new Button();
            label3 = new Label();
            label4 = new Label();
            startPositionX = new TextBox();
            label5 = new Label();
            label6 = new Label();
            startPositionY = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numOfRows = new TextBox();
            numOfColumns = new TextBox();
            dontConsiderThese = new Label();
            omitThese = new TextBox();
            seePreviousFile = new Button();
            seeNextFile = new Button();
            label9 = new Label();
            saveFilePath = new TextBox();
            saveButton = new Button();
            convertImageToGray = new CheckBox();
            label10 = new Label();
            squareSize = new TextBox();
            imageList = new ImageList(components);
            label12 = new Label();
            helpToolStripMenuItem = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            harHarHarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            qələmToolStripMenuItem = new ToolStripMenuItem();
            increaseRowNo = new Button();
            increaseColNo = new Button();
            increaseSquareSize = new Button();
            decreaseRowNo = new Button();
            decreaseColNo = new Button();
            decreaseSquareSize = new Button();
            label11 = new Label();
            distanceBetweenSqrs = new TextBox();
            decreaseDistBS = new Button();
            increaseDistBS = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showSquaresCheckBox = new CheckBox();
            testPicBox = new PictureBox();
            picNumUpDown = new NumericUpDown();
            thisImageIndex = new Label();
            allImagesCount = new Label();
            progressBar1 = new ProgressBar();
            progressbarLabel = new Label();
            progressbarTotalImages = new Label();
            progressbarDoneImages = new Label();
            progressbarSlash = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)testPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // selectPics
            // 
            selectPics.Font = new Font("Segoe UI", 12F);
            selectPics.ForeColor = Color.Black;
            selectPics.Location = new Point(33, 38);
            selectPics.Name = "selectPics";
            selectPics.RightToLeft = RightToLeft.No;
            selectPics.Size = new Size(100, 20);
            selectPics.TabIndex = 0;
            selectPics.Text = "Üçüzlərı Seç";
            selectPics.Click += label1_Click;
            // 
            // openFilePath
            // 
            openFilePath.AllowDrop = true;
            openFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openFilePath.Location = new Point(33, 74);
            openFilePath.Name = "openFilePath";
            openFilePath.Size = new Size(681, 23);
            openFilePath.TabIndex = 0;
            openFilePath.TextChanged += openFilePath_TextChanged;
            // 
            // browsImages
            // 
            browsImages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browsImages.BackColor = Color.DeepSkyBlue;
            browsImages.FlatAppearance.BorderSize = 0;
            browsImages.FlatStyle = FlatStyle.Flat;
            browsImages.Font = new Font("Segoe UI", 12F);
            browsImages.Location = new Point(726, 67);
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
            pictureBox1.Location = new Point(433, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 229);
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
            label1.Size = new Size(701, 1);
            label1.TabIndex = 999;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(62, 410);
            label2.Name = "label2";
            label2.Size = new Size(701, 1);
            label2.TabIndex = 999;
            label2.Click += label1_Click_1;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.BackColor = Color.Chartreuse;
            okButton.Enabled = false;
            okButton.FlatAppearance.BorderColor = Color.Chartreuse;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Segoe UI", 11F);
            okButton.Location = new Point(726, 496);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 45);
            okButton.TabIndex = 11;
            okButton.Text = "Oldu, Yaxçı";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.BackColor = Color.OrangeRed;
            exitButton.FlatAppearance.BorderColor = Color.OrangeRed;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 11F);
            exitButton.Location = new Point(610, 496);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(105, 45);
            exitButton.TabIndex = 1000;
            exitButton.Text = "Bırax, İstəmır";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
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
            // startPositionX
            // 
            startPositionX.Enabled = false;
            startPositionX.Location = new Point(264, 172);
            startPositionX.Name = "startPositionX";
            startPositionX.Size = new Size(47, 23);
            startPositionX.TabIndex = 3;
            startPositionX.Text = "10";
            startPositionX.TextAlign = HorizontalAlignment.Center;
            startPositionX.TextChanged += startPositionX_TextChanged;
            startPositionX.Leave += startPositionX_Leave;
            // 
            // label5
            // 
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(317, 175);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 0;
            label5.Text = "X";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(331, 175);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 0;
            label6.Text = "Y";
            label6.Click += label1_Click;
            // 
            // startPositionY
            // 
            startPositionY.Enabled = false;
            startPositionY.Location = new Point(354, 172);
            startPositionY.Name = "startPositionY";
            startPositionY.Size = new Size(47, 23);
            startPositionY.TabIndex = 4;
            startPositionY.Text = "10";
            startPositionY.TextAlign = HorizontalAlignment.Center;
            startPositionY.TextChanged += startPositionY_TextChanged;
            startPositionY.Leave += startPositionY_Leave;
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
            // numOfRows
            // 
            numOfRows.Enabled = false;
            numOfRows.Location = new Point(310, 212);
            numOfRows.Name = "numOfRows";
            numOfRows.Size = new Size(47, 23);
            numOfRows.TabIndex = 5;
            numOfRows.Text = "8";
            numOfRows.TextAlign = HorizontalAlignment.Center;
            numOfRows.TextChanged += numOfRows_TextChanged;
            numOfRows.Leave += numOfRows_Leave;
            // 
            // numOfColumns
            // 
            numOfColumns.Enabled = false;
            numOfColumns.Location = new Point(310, 252);
            numOfColumns.Name = "numOfColumns";
            numOfColumns.Size = new Size(47, 23);
            numOfColumns.TabIndex = 6;
            numOfColumns.Text = "8";
            numOfColumns.TextAlign = HorizontalAlignment.Center;
            numOfColumns.TextChanged += numOfColumns_TextChanged;
            numOfColumns.Leave += numOfColumns_Leave;
            // 
            // dontConsiderThese
            // 
            dontConsiderThese.Font = new Font("Segoe UI", 12F);
            dontConsiderThese.ForeColor = Color.Black;
            dontConsiderThese.Location = new Point(62, 372);
            dontConsiderThese.Name = "dontConsiderThese";
            dontConsiderThese.Size = new Size(132, 20);
            dontConsiderThese.TabIndex = 0;
            dontConsiderThese.Text = "Bıları Gözə Alma:";
            dontConsiderThese.Click += label1_Click;
            // 
            // omitThese
            // 
            omitThese.Enabled = false;
            omitThese.Location = new Point(264, 372);
            omitThese.Name = "omitThese";
            omitThese.Size = new Size(137, 23);
            omitThese.TabIndex = 9;
            omitThese.Text = "1, 8";
            omitThese.TextChanged += omitThese_TextChanged;
            omitThese.Leave += omitThese_Leave;
            // 
            // seePreviousFile
            // 
            seePreviousFile.Anchor = AnchorStyles.Right;
            seePreviousFile.Enabled = false;
            seePreviousFile.Location = new Point(590, 370);
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
            seeNextFile.Location = new Point(653, 370);
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
            label9.Location = new Point(33, 419);
            label9.Name = "label9";
            label9.Size = new Size(172, 20);
            label9.TabIndex = 0;
            label9.Text = "Sonucları Bırda Saxla";
            label9.Click += label1_Click;
            // 
            // saveFilePath
            // 
            saveFilePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveFilePath.Location = new Point(33, 455);
            saveFilePath.Name = "saveFilePath";
            saveFilePath.Size = new Size(681, 23);
            saveFilePath.TabIndex = 998;
            saveFilePath.TextChanged += saveFilePath_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.BackColor = Color.DeepSkyBlue;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 12F);
            saveButton.Location = new Point(726, 448);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(90, 35);
            saveButton.TabIndex = 10;
            saveButton.Text = "Gəz";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // convertImageToGray
            // 
            convertImageToGray.AutoSize = true;
            convertImageToGray.Enabled = false;
            convertImageToGray.Location = new Point(109, 139);
            convertImageToGray.Name = "convertImageToGray";
            convertImageToGray.Size = new Size(110, 19);
            convertImageToGray.TabIndex = 2;
            convertImageToGray.Text = "Üçüzlərı Boazart";
            convertImageToGray.TextAlign = ContentAlignment.MiddleCenter;
            convertImageToGray.UseVisualStyleBackColor = true;
            convertImageToGray.CheckedChanged += convertImageToGray_CheckedChanged;
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
            // squareSize
            // 
            squareSize.Enabled = false;
            squareSize.Location = new Point(310, 292);
            squareSize.Name = "squareSize";
            squareSize.Size = new Size(47, 23);
            squareSize.TabIndex = 7;
            squareSize.Text = "10";
            squareSize.TextAlign = HorizontalAlignment.Center;
            squareSize.TextChanged += squareSize_TextChanged;
            squareSize.Leave += squareSize_Leave;
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
            label12.Location = new Point(628, 374);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, qələmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(844, 24);
            menuStrip1.TabIndex = 1003;
            menuStrip1.Text = "menuStrip1";
            // 
            // qələmToolStripMenuItem
            // 
            qələmToolStripMenuItem.Name = "qələmToolStripMenuItem";
            qələmToolStripMenuItem.Size = new Size(54, 20);
            qələmToolStripMenuItem.Text = "Qələm";
            // 
            // increaseRowNo
            // 
            increaseRowNo.Enabled = false;
            increaseRowNo.Location = new Point(363, 212);
            increaseRowNo.Name = "increaseRowNo";
            increaseRowNo.Size = new Size(38, 23);
            increaseRowNo.TabIndex = 1007;
            increaseRowNo.Text = "çox";
            increaseRowNo.UseVisualStyleBackColor = true;
            increaseRowNo.Click += increaseRowNo_Click;
            // 
            // increaseColNo
            // 
            increaseColNo.Enabled = false;
            increaseColNo.Location = new Point(363, 252);
            increaseColNo.Name = "increaseColNo";
            increaseColNo.Size = new Size(38, 23);
            increaseColNo.TabIndex = 1007;
            increaseColNo.Text = "çox";
            increaseColNo.UseVisualStyleBackColor = true;
            increaseColNo.Click += increaseColNo_Click;
            // 
            // increaseSquareSize
            // 
            increaseSquareSize.Enabled = false;
            increaseSquareSize.Location = new Point(363, 292);
            increaseSquareSize.Name = "increaseSquareSize";
            increaseSquareSize.Size = new Size(38, 23);
            increaseSquareSize.TabIndex = 1007;
            increaseSquareSize.Text = "çox";
            increaseSquareSize.UseVisualStyleBackColor = true;
            increaseSquareSize.Click += increaseSquareSize_Click;
            // 
            // decreaseRowNo
            // 
            decreaseRowNo.Enabled = false;
            decreaseRowNo.Location = new Point(264, 212);
            decreaseRowNo.Name = "decreaseRowNo";
            decreaseRowNo.Size = new Size(38, 23);
            decreaseRowNo.TabIndex = 1007;
            decreaseRowNo.Text = "az";
            decreaseRowNo.UseVisualStyleBackColor = true;
            decreaseRowNo.Click += decreaseRowNo_Click;
            // 
            // decreaseColNo
            // 
            decreaseColNo.Enabled = false;
            decreaseColNo.Location = new Point(264, 252);
            decreaseColNo.Name = "decreaseColNo";
            decreaseColNo.Size = new Size(38, 23);
            decreaseColNo.TabIndex = 1007;
            decreaseColNo.Text = "az";
            decreaseColNo.UseVisualStyleBackColor = true;
            decreaseColNo.Click += decreaseColNo_Click;
            // 
            // decreaseSquareSize
            // 
            decreaseSquareSize.Enabled = false;
            decreaseSquareSize.Location = new Point(264, 293);
            decreaseSquareSize.Name = "decreaseSquareSize";
            decreaseSquareSize.Size = new Size(38, 23);
            decreaseSquareSize.TabIndex = 1007;
            decreaseSquareSize.Text = "az";
            decreaseSquareSize.UseVisualStyleBackColor = true;
            decreaseSquareSize.Click += decreaseSquareSize_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(62, 332);
            label11.Name = "label11";
            label11.Size = new Size(183, 24);
            label11.TabIndex = 0;
            label11.Text = "Dörtbıcaqların Arası:";
            label11.Click += label1_Click;
            // 
            // distanceBetweenSqrs
            // 
            distanceBetweenSqrs.Enabled = false;
            distanceBetweenSqrs.Location = new Point(310, 332);
            distanceBetweenSqrs.Name = "distanceBetweenSqrs";
            distanceBetweenSqrs.Size = new Size(47, 23);
            distanceBetweenSqrs.TabIndex = 8;
            distanceBetweenSqrs.Text = "2";
            distanceBetweenSqrs.TextAlign = HorizontalAlignment.Center;
            distanceBetweenSqrs.TextChanged += distanceBetweenSqrs_TextChanged;
            distanceBetweenSqrs.Leave += distanceBetweenSqrs_Leave;
            // 
            // decreaseDistBS
            // 
            decreaseDistBS.Enabled = false;
            decreaseDistBS.Location = new Point(264, 332);
            decreaseDistBS.Name = "decreaseDistBS";
            decreaseDistBS.Size = new Size(38, 23);
            decreaseDistBS.TabIndex = 1007;
            decreaseDistBS.Text = "az";
            decreaseDistBS.UseVisualStyleBackColor = true;
            decreaseDistBS.Click += decreaseDistBS_Click;
            // 
            // increaseDistBS
            // 
            increaseDistBS.Enabled = false;
            increaseDistBS.Location = new Point(363, 332);
            increaseDistBS.Name = "increaseDistBS";
            increaseDistBS.Size = new Size(38, 23);
            increaseDistBS.TabIndex = 1007;
            increaseDistBS.Text = "çox";
            increaseDistBS.UseVisualStyleBackColor = true;
            increaseDistBS.Click += increaseDistBS_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // showSquaresCheckBox
            // 
            showSquaresCheckBox.AutoSize = true;
            showSquaresCheckBox.Checked = true;
            showSquaresCheckBox.CheckState = CheckState.Checked;
            showSquaresCheckBox.Enabled = false;
            showSquaresCheckBox.Location = new Point(222, 139);
            showSquaresCheckBox.Name = "showSquaresCheckBox";
            showSquaresCheckBox.Size = new Size(131, 19);
            showSquaresCheckBox.TabIndex = 2;
            showSquaresCheckBox.Text = "Dörtbıcaqları Görsət";
            showSquaresCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            showSquaresCheckBox.UseVisualStyleBackColor = true;
            showSquaresCheckBox.CheckedChanged += showSquaresCheckBox_CheckedChanged;
            // 
            // testPicBox
            // 
            testPicBox.Location = new Point(389, 487);
            testPicBox.Name = "testPicBox";
            testPicBox.Size = new Size(63, 38);
            testPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            testPicBox.TabIndex = 1008;
            testPicBox.TabStop = false;
            testPicBox.Visible = false;
            // 
            // picNumUpDown
            // 
            picNumUpDown.Location = new Point(458, 493);
            picNumUpDown.Name = "picNumUpDown";
            picNumUpDown.Size = new Size(79, 23);
            picNumUpDown.TabIndex = 1009;
            picNumUpDown.Visible = false;
            picNumUpDown.ValueChanged += picNumUpDown_ValueChanged;
            // 
            // thisImageIndex
            // 
            thisImageIndex.Anchor = AnchorStyles.Right;
            thisImageIndex.AutoSize = true;
            thisImageIndex.FlatStyle = FlatStyle.Flat;
            thisImageIndex.Font = new Font("Segoe UI", 9F);
            thisImageIndex.Location = new Point(613, 374);
            thisImageIndex.Name = "thisImageIndex";
            thisImageIndex.Size = new Size(17, 15);
            thisImageIndex.TabIndex = 1010;
            thisImageIndex.Text = "??";
            thisImageIndex.TextAlign = ContentAlignment.MiddleRight;
            // 
            // allImagesCount
            // 
            allImagesCount.Anchor = AnchorStyles.Right;
            allImagesCount.AutoSize = true;
            allImagesCount.Font = new Font("Segoe UI", 9F);
            allImagesCount.Location = new Point(635, 374);
            allImagesCount.Name = "allImagesCount";
            allImagesCount.Size = new Size(17, 15);
            allImagesCount.TabIndex = 1010;
            allImagesCount.Text = "??";
            allImagesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 531);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(559, 10);
            progressBar1.TabIndex = 1011;
            progressBar1.Visible = false;
            // 
            // progressbarLabel
            // 
            progressbarLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressbarLabel.Font = new Font("Segoe UI", 9F);
            progressbarLabel.ForeColor = Color.Black;
            progressbarLabel.Location = new Point(33, 505);
            progressbarLabel.Name = "progressbarLabel";
            progressbarLabel.Size = new Size(142, 20);
            progressbarLabel.TabIndex = 0;
            progressbarLabel.Text = "Çox Önəmlı İşlər Görürək ";
            progressbarLabel.TextAlign = ContentAlignment.BottomLeft;
            progressbarLabel.Visible = false;
            progressbarLabel.Click += label1_Click;
            // 
            // progressbarTotalImages
            // 
            progressbarTotalImages.AutoSize = true;
            progressbarTotalImages.Location = new Point(202, 509);
            progressbarTotalImages.Name = "progressbarTotalImages";
            progressbarTotalImages.RightToLeft = RightToLeft.No;
            progressbarTotalImages.Size = new Size(21, 15);
            progressbarTotalImages.TabIndex = 1012;
            progressbarTotalImages.Text = "??)";
            progressbarTotalImages.Visible = false;
            // 
            // progressbarDoneImages
            // 
            progressbarDoneImages.AutoSize = true;
            progressbarDoneImages.Location = new Point(171, 509);
            progressbarDoneImages.Name = "progressbarDoneImages";
            progressbarDoneImages.Size = new Size(21, 15);
            progressbarDoneImages.TabIndex = 1012;
            progressbarDoneImages.Text = "(??";
            progressbarDoneImages.Visible = false;
            // 
            // progressbarSlash
            // 
            progressbarSlash.AutoSize = true;
            progressbarSlash.Location = new Point(192, 510);
            progressbarSlash.Name = "progressbarSlash";
            progressbarSlash.RightToLeft = RightToLeft.No;
            progressbarSlash.Size = new Size(12, 15);
            progressbarSlash.TabIndex = 1012;
            progressbarSlash.Text = "/";
            progressbarSlash.Visible = false;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(844, 551);
            Controls.Add(progressbarDoneImages);
            Controls.Add(progressbarSlash);
            Controls.Add(progressbarTotalImages);
            Controls.Add(progressBar1);
            Controls.Add(allImagesCount);
            Controls.Add(thisImageIndex);
            Controls.Add(picNumUpDown);
            Controls.Add(testPicBox);
            Controls.Add(increaseDistBS);
            Controls.Add(increaseSquareSize);
            Controls.Add(increaseColNo);
            Controls.Add(decreaseDistBS);
            Controls.Add(decreaseSquareSize);
            Controls.Add(decreaseColNo);
            Controls.Add(decreaseRowNo);
            Controls.Add(increaseRowNo);
            Controls.Add(label12);
            Controls.Add(showSquaresCheckBox);
            Controls.Add(convertImageToGray);
            Controls.Add(seeNextFile);
            Controls.Add(seePreviousFile);
            Controls.Add(startPositionY);
            Controls.Add(omitThese);
            Controls.Add(distanceBetweenSqrs);
            Controls.Add(squareSize);
            Controls.Add(numOfColumns);
            Controls.Add(numOfRows);
            Controls.Add(startPositionX);
            Controls.Add(exitButton);
            Controls.Add(okButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(saveButton);
            Controls.Add(browsImages);
            Controls.Add(saveFilePath);
            Controls.Add(openFilePath);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dontConsiderThese);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(progressbarLabel);
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
            ((System.ComponentModel.ISupportInitialize)testPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectPics;
        private TextBox openFilePath;
        private Label label1;
        private Label label2;
        private Button okButton;
        private Button exitButton;
        private Label label3;
        private Label label4;
        private TextBox startPositionX;
        private Label label5;
        private Label label6;
        private TextBox startPositionY;
        private Label label7;
        private Label label8;
        private TextBox numOfRows;
        private TextBox numOfColumns;
        private Label dontConsiderThese;
        private TextBox omitThese;
        private Button seePreviousFile;
        private Button seeNextFile;
        private Label label9;
        private TextBox saveFilePath;
        private Button saveButton;
        private CheckBox convertImageToGray;
        private Label label10;
        private TextBox squareSize;
        public Button browsImages;
        private ImageList imageList;
        private Label label12;
        public PictureBox pictureBox1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem harHarHarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button increaseRowNo;
        private Button increaseColNo;
        private Button increaseSquareSize;
        private Button decreaseRowNo;
        private Button decreaseColNo;
        private Button decreaseSquareSize;
        private Label label11;
        private TextBox distanceBetweenSqrs;
        private Button decreaseDistBS;
        private Button increaseDistBS;
        private ToolStripMenuItem qələmToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox showSquaresCheckBox;
        private PictureBox testPicBox;
        private NumericUpDown picNumUpDown;
        private Label thisImageIndex;
        private Label allImagesCount;
        private ProgressBar progressBar1;
        private Label progressbarLabel;
        private Label progressbarTotalImages;
        private Label progressbarDoneImages;
        private Label progressbarSlash;
    }
}
