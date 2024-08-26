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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            dilLanguageToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            harHarHarToolStripMenuItem = new ToolStripMenuItem();
            qələmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            findiqliyamToolStripMenuItem = new ToolStripMenuItem();
            niyaToolStripMenuItem = new ToolStripMenuItem();
            UnconsistentImageSize = new ToolStripMenuItem();
            ImagesNotTriple = new ToolStripMenuItem();
            bizaGoraToolStripMenuItem = new ToolStripMenuItem();
            englishUSToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNumUpDown).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // selectPics
            // 
            resources.ApplyResources(selectPics, "selectPics");
            selectPics.ForeColor = Color.Black;
            selectPics.Name = "selectPics";
            selectPics.Click += label1_Click;
            // 
            // openFilePath
            // 
            resources.ApplyResources(openFilePath, "openFilePath");
            openFilePath.AllowDrop = true;
            openFilePath.Name = "openFilePath";
            openFilePath.TextChanged += openFilePath_TextChanged;
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
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Name = "label2";
            label2.Click += label1_Click_1;
            // 
            // okButton
            // 
            resources.ApplyResources(okButton, "okButton");
            okButton.BackColor = Color.Chartreuse;
            okButton.FlatAppearance.BorderColor = Color.Chartreuse;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Name = "okButton";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // exitButton
            // 
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.BackColor = Color.OrangeRed;
            exitButton.FlatAppearance.BorderColor = Color.OrangeRed;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Black;
            label3.Name = "label3";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Black;
            label4.Name = "label4";
            label4.Click += label1_Click;
            // 
            // startPositionX
            // 
            resources.ApplyResources(startPositionX, "startPositionX");
            startPositionX.Name = "startPositionX";
            startPositionX.TextChanged += startPositionX_TextChanged;
            startPositionX.Leave += startPositionX_Leave;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Black;
            label5.Name = "label5";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Black;
            label6.Name = "label6";
            label6.Click += label1_Click;
            // 
            // startPositionY
            // 
            resources.ApplyResources(startPositionY, "startPositionY");
            startPositionY.Name = "startPositionY";
            startPositionY.TextChanged += startPositionY_TextChanged;
            startPositionY.Leave += startPositionY_Leave;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Black;
            label7.Name = "label7";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.Black;
            label8.Name = "label8";
            label8.Click += label1_Click;
            // 
            // numOfRows
            // 
            resources.ApplyResources(numOfRows, "numOfRows");
            numOfRows.Name = "numOfRows";
            numOfRows.TextChanged += numOfRows_TextChanged;
            numOfRows.Leave += numOfRows_Leave;
            // 
            // numOfColumns
            // 
            resources.ApplyResources(numOfColumns, "numOfColumns");
            numOfColumns.Name = "numOfColumns";
            numOfColumns.TextChanged += numOfColumns_TextChanged;
            numOfColumns.Leave += numOfColumns_Leave;
            // 
            // dontConsiderThese
            // 
            resources.ApplyResources(dontConsiderThese, "dontConsiderThese");
            dontConsiderThese.ForeColor = Color.Black;
            dontConsiderThese.Name = "dontConsiderThese";
            dontConsiderThese.Click += label1_Click;
            // 
            // omitThese
            // 
            resources.ApplyResources(omitThese, "omitThese");
            omitThese.Name = "omitThese";
            omitThese.TextChanged += omitThese_TextChanged;
            omitThese.Leave += omitThese_Leave;
            // 
            // seePreviousFile
            // 
            resources.ApplyResources(seePreviousFile, "seePreviousFile");
            seePreviousFile.Name = "seePreviousFile";
            seePreviousFile.UseVisualStyleBackColor = true;
            seePreviousFile.Click += seePreviousFile_Click;
            // 
            // seeNextFile
            // 
            resources.ApplyResources(seeNextFile, "seeNextFile");
            seeNextFile.Name = "seeNextFile";
            seeNextFile.UseVisualStyleBackColor = true;
            seeNextFile.Click += seeNextFile_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.Black;
            label9.Name = "label9";
            label9.Click += label1_Click;
            // 
            // saveFilePath
            // 
            resources.ApplyResources(saveFilePath, "saveFilePath");
            saveFilePath.Name = "saveFilePath";
            saveFilePath.TextChanged += saveFilePath_TextChanged;
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.BackColor = Color.DeepSkyBlue;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // convertImageToGray
            // 
            resources.ApplyResources(convertImageToGray, "convertImageToGray");
            convertImageToGray.Name = "convertImageToGray";
            convertImageToGray.UseVisualStyleBackColor = true;
            convertImageToGray.CheckedChanged += convertImageToGray_CheckedChanged;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.Black;
            label10.Name = "label10";
            label10.Click += label1_Click;
            // 
            // squareSize
            // 
            resources.ApplyResources(squareSize, "squareSize");
            squareSize.Name = "squareSize";
            squareSize.TextChanged += squareSize_TextChanged;
            squareSize.Leave += squareSize_Leave;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            resources.ApplyResources(imageList, "imageList");
            imageList.TransparentColor = Color.Transparent;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // increaseRowNo
            // 
            resources.ApplyResources(increaseRowNo, "increaseRowNo");
            increaseRowNo.Name = "increaseRowNo";
            increaseRowNo.UseVisualStyleBackColor = true;
            increaseRowNo.Click += increaseRowNo_Click;
            // 
            // increaseColNo
            // 
            resources.ApplyResources(increaseColNo, "increaseColNo");
            increaseColNo.Name = "increaseColNo";
            increaseColNo.UseVisualStyleBackColor = true;
            increaseColNo.Click += increaseColNo_Click;
            // 
            // increaseSquareSize
            // 
            resources.ApplyResources(increaseSquareSize, "increaseSquareSize");
            increaseSquareSize.Name = "increaseSquareSize";
            increaseSquareSize.UseVisualStyleBackColor = true;
            increaseSquareSize.Click += increaseSquareSize_Click;
            // 
            // decreaseRowNo
            // 
            resources.ApplyResources(decreaseRowNo, "decreaseRowNo");
            decreaseRowNo.Name = "decreaseRowNo";
            decreaseRowNo.UseVisualStyleBackColor = true;
            decreaseRowNo.Click += decreaseRowNo_Click;
            // 
            // decreaseColNo
            // 
            resources.ApplyResources(decreaseColNo, "decreaseColNo");
            decreaseColNo.Name = "decreaseColNo";
            decreaseColNo.UseVisualStyleBackColor = true;
            decreaseColNo.Click += decreaseColNo_Click;
            // 
            // decreaseSquareSize
            // 
            resources.ApplyResources(decreaseSquareSize, "decreaseSquareSize");
            decreaseSquareSize.Name = "decreaseSquareSize";
            decreaseSquareSize.UseVisualStyleBackColor = true;
            decreaseSquareSize.Click += decreaseSquareSize_Click;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.Black;
            label11.Name = "label11";
            label11.Click += label1_Click;
            // 
            // distanceBetweenSqrs
            // 
            resources.ApplyResources(distanceBetweenSqrs, "distanceBetweenSqrs");
            distanceBetweenSqrs.Name = "distanceBetweenSqrs";
            distanceBetweenSqrs.TextChanged += distanceBetweenSqrs_TextChanged;
            distanceBetweenSqrs.Leave += distanceBetweenSqrs_Leave;
            // 
            // decreaseDistBS
            // 
            resources.ApplyResources(decreaseDistBS, "decreaseDistBS");
            decreaseDistBS.Name = "decreaseDistBS";
            decreaseDistBS.UseVisualStyleBackColor = true;
            decreaseDistBS.Click += decreaseDistBS_Click;
            // 
            // increaseDistBS
            // 
            resources.ApplyResources(increaseDistBS, "increaseDistBS");
            increaseDistBS.Name = "increaseDistBS";
            increaseDistBS.UseVisualStyleBackColor = true;
            increaseDistBS.Click += increaseDistBS_Click;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // showSquaresCheckBox
            // 
            resources.ApplyResources(showSquaresCheckBox, "showSquaresCheckBox");
            showSquaresCheckBox.Checked = true;
            showSquaresCheckBox.CheckState = CheckState.Checked;
            showSquaresCheckBox.Name = "showSquaresCheckBox";
            showSquaresCheckBox.UseVisualStyleBackColor = true;
            showSquaresCheckBox.CheckedChanged += showSquaresCheckBox_CheckedChanged;
            // 
            // testPicBox
            // 
            resources.ApplyResources(testPicBox, "testPicBox");
            testPicBox.Name = "testPicBox";
            testPicBox.TabStop = false;
            // 
            // picNumUpDown
            // 
            resources.ApplyResources(picNumUpDown, "picNumUpDown");
            picNumUpDown.Name = "picNumUpDown";
            picNumUpDown.ValueChanged += picNumUpDown_ValueChanged;
            // 
            // thisImageIndex
            // 
            resources.ApplyResources(thisImageIndex, "thisImageIndex");
            thisImageIndex.FlatStyle = FlatStyle.Flat;
            thisImageIndex.Name = "thisImageIndex";
            // 
            // allImagesCount
            // 
            resources.ApplyResources(allImagesCount, "allImagesCount");
            allImagesCount.Name = "allImagesCount";
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // progressbarLabel
            // 
            resources.ApplyResources(progressbarLabel, "progressbarLabel");
            progressbarLabel.ForeColor = Color.Black;
            progressbarLabel.Name = "progressbarLabel";
            progressbarLabel.Click += label1_Click;
            // 
            // progressbarTotalImages
            // 
            resources.ApplyResources(progressbarTotalImages, "progressbarTotalImages");
            progressbarTotalImages.Name = "progressbarTotalImages";
            // 
            // progressbarDoneImages
            // 
            resources.ApplyResources(progressbarDoneImages, "progressbarDoneImages");
            progressbarDoneImages.Name = "progressbarDoneImages";
            // 
            // progressbarSlash
            // 
            resources.ApplyResources(progressbarSlash, "progressbarSlash");
            progressbarSlash.Name = "progressbarSlash";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilLanguageToolStripMenuItem, licenceToolStripMenuItem, yardımToolStripMenuItem, harHarHarToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // dilLanguageToolStripMenuItem
            // 
            resources.ApplyResources(dilLanguageToolStripMenuItem, "dilLanguageToolStripMenuItem");
            dilLanguageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, englishUSToolStripMenuItem });
            dilLanguageToolStripMenuItem.Name = "dilLanguageToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // licenceToolStripMenuItem
            // 
            resources.ApplyResources(licenceToolStripMenuItem, "licenceToolStripMenuItem");
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            // 
            // yardımToolStripMenuItem
            // 
            resources.ApplyResources(yardımToolStripMenuItem, "yardımToolStripMenuItem");
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            // 
            // harHarHarToolStripMenuItem
            // 
            resources.ApplyResources(harHarHarToolStripMenuItem, "harHarHarToolStripMenuItem");
            harHarHarToolStripMenuItem.Name = "harHarHarToolStripMenuItem";
            // 
            // qələmToolStripMenuItem
            // 
            resources.ApplyResources(qələmToolStripMenuItem, "qələmToolStripMenuItem");
            qələmToolStripMenuItem.Name = "qələmToolStripMenuItem";
            qələmToolStripMenuItem.Click += qələmToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, qələmToolStripMenuItem, findiqliyamToolStripMenuItem, bizaGoraToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // findiqliyamToolStripMenuItem
            // 
            resources.ApplyResources(findiqliyamToolStripMenuItem, "findiqliyamToolStripMenuItem");
            findiqliyamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { niyaToolStripMenuItem });
            findiqliyamToolStripMenuItem.Name = "findiqliyamToolStripMenuItem";
            // 
            // niyaToolStripMenuItem
            // 
            resources.ApplyResources(niyaToolStripMenuItem, "niyaToolStripMenuItem");
            niyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UnconsistentImageSize, ImagesNotTriple });
            niyaToolStripMenuItem.Name = "niyaToolStripMenuItem";
            // 
            // UnconsistentImageSize
            // 
            resources.ApplyResources(UnconsistentImageSize, "UnconsistentImageSize");
            UnconsistentImageSize.Name = "UnconsistentImageSize";
            UnconsistentImageSize.Click += UnconsistentImageSize_Click;
            // 
            // ImagesNotTriple
            // 
            resources.ApplyResources(ImagesNotTriple, "ImagesNotTriple");
            ImagesNotTriple.Name = "ImagesNotTriple";
            ImagesNotTriple.Click += ImagesNotTriple_Click;
            // 
            // bizaGoraToolStripMenuItem
            // 
            resources.ApplyResources(bizaGoraToolStripMenuItem, "bizaGoraToolStripMenuItem");
            bizaGoraToolStripMenuItem.Name = "bizaGoraToolStripMenuItem";
            bizaGoraToolStripMenuItem.Click += bizaGoraToolStripMenuItem_Click;
            // 
            // englishUSToolStripMenuItem
            // 
            resources.ApplyResources(englishUSToolStripMenuItem, "englishUSToolStripMenuItem");
            englishUSToolStripMenuItem.Name = "englishUSToolStripMenuItem";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
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
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            DragLeave += Form1_DragLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)testPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNumUpDown).EndInit();
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
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem harHarHarToolStripMenuItem;
        private ToolStripMenuItem qələmToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bizaGoraToolStripMenuItem;
        private ToolStripMenuItem findiqliyamToolStripMenuItem;
        private ToolStripMenuItem niyaToolStripMenuItem;
        private ToolStripMenuItem UnconsistentImageSize;
        private ToolStripMenuItem ImagesNotTriple;
        private ToolStripMenuItem dilLanguageToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem englishUSToolStripMenuItem;
    }
}
