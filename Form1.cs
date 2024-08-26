//using SixLabors.ImageSharp;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Windows.Forms;
using System.CodeDom;
using MultiLanguageTest_01;

namespace ADBoyaSU
{
    public partial class Form1 : Form
    {
        // Azərbaycan Hərflərı:
        // Ü İ Ö Ğ I Ə Ç Ş
        // ü i ö ğ ı ə ç ş
        // Türkü Azərbaycan
        Thread calculatorThread;

        public bool convertToGray = false;
        public bool showSquares = true;
        Image? workingImage;
        Graphics? graphics;

        // Select Files
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string[] fileNames;
        //Size fis;   // first image size
        //Size csis;  // currently showing image size

        public int imageIndex = 0;
        public string? currentFilePath;

        //imageManipulation IM = new imageManipulation();

        public Color penColor = Color.DarkViolet;
        public float penThickness = 3f;

        public float spX = 10; // starting point x
        public float spY = 10; // starting point y
        public int noR = 3;    // number of rows
        public int noC = 5;    // number of columns
        public float soS = 10; // size of squares
        public float dbS = 2;  // distance between squares

        public int noRDecStep = 1; // the step by which numberOfRows value is decreased
        public int noRIncStep = 1; // the step by which numberOfRows value is increased
        public int noCDecStep = 1; // the step by which numberOfCols value is decreased
        public int noCIncStep = 1; // the step by which numberOfCols value is increased
        public float soSDecStep = 0.5f; // the step by which sizeOfSquare value is decreased
        public float soSIncStep = 0.5f; // the step by which sizeOfSquare value is increased
        public float dbSDecStep = 0.5f; // the step by which distanceBetweenSquares value in decreased
        public float dbSIncStep = 0.5f; // the step by which distanceBetweenSquares value in increased

        // Text Changed of Settings
        string wrongInputSettings_message = "\tDüzgün Bir Sayı Yaz.";
        string wrongInputSettings_caption = "Savadsız";

        // Omit These
        public string[]? toOmitStr;
        public int[]? toOmitInt;

        // Visually Nice
        int desiredLength = 14; // desired length for the first column

        // ThisSquareValue
        int imagesOfAKind = 3;  // number of images that represent same sound
        List<Image> testLittleSquares = new List<Image>();
        bool galmisdikQabaxdan = false;
        //Image[] testLittleSquares;

        // Saving
        public string saveAddress_1 = "";
        public string saveAddress_2 = "";
        public string saveAddress_3 = "";

        // Drag and drop
        Color form1Color, menuStrip1Color;
        string[] dragedFiles;
        List<string> tempDragedFiles = new List<string>();


        public Form1()
        {
            InitializeComponent();
            noR = Convert.ToInt32(numOfRows.Text);
            noC = Convert.ToInt32(numOfColumns.Text);

        }

        #region Image selection and display
        private void browsImages_Click(object sender, EventArgs e)
        {
            // Selecting the image
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "image files|*.png;*.jpg;*.gif";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            // only for the first file selection. 
            if (dialogResult == DialogResult.OK)
            {
                //fileNames = fileNames;
                //EnableControls(1);

                WeHaveImagesNow(openFileDialog.FileNames);
            }
        }

        public void WeHaveImagesNow(string[] names)
        {
            fileNames = names;
            //fis = Image.FromFile(fileNames[0]).Size;

            try
            {
                //allImagesCount.Text = fileNames.Count().ToString();
                allImagesCount.TextAlign = ContentAlignment.MiddleCenter;
                allImagesCount.Text = fileNames.Count().ToString();

                EnableControls(1);

                // Dispaly images in the picuteBox1
                imageIndex = 0;
                SelectImage(0);
            }
            catch (Exception)
            {
                EnableControls(0);
                pictureBox1.Image = null;

                browsImages.Enabled = true;
                saveButton.Enabled = true;
                saveFilePath.Enabled = true;
                openFilePath.Text = "";

                allImagesCount.Text = "???";
                thisImageIndex.Text = "???";

                ScrollButtonsConditioner();


                MessageBox.Show("Üstündə İşləmək Üçün 'İmage' Yox Bacı, 'İmage'...", "Birzad Seçməmışez");

            }

            // Hide the progressbar
            ProgressbarVisiblitiy(0);
        }

        public void SelectImage(int direction)
        {
            thisImageIndex.TextAlign = ContentAlignment.MiddleCenter;

            if (direction == 0)
            {
                currentFilePath = fileNames[imageIndex];
                thisImageIndex.Text = (imageIndex + 1).ToString();
            }
            else if (direction == 1 && ++imageIndex <= fileNames.Length - 1)
            {
                currentFilePath = fileNames[imageIndex];
                thisImageIndex.Text = (imageIndex + 1).ToString();

            }
            else if (direction == -1 && --imageIndex >= 0)
            {
                currentFilePath = fileNames[imageIndex];
                thisImageIndex.Text = (imageIndex + 1).ToString();

            }


            openFilePath.Text = currentFilePath;


            ScrollButtonsConditioner();
        }

        private void seePreviousFile_Click(object sender, EventArgs e)
        {
            SelectImage(-1);
        }

        private void seeNextFile_Click(object sender, EventArgs e)
        {
            SelectImage(1);
        }

        private void openFilePath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ShowMeMyImage(openFilePath.Text);

                if (fileNames.Count() == 1)
                    EnableControls(1);
            }
            catch (FileNotFoundException)
            {
                pictureBox1.Image = null;
            }
            catch (Exception)
            {
                if (openFilePath.Text.Trim() != "")
                    ShowMeMyImage(fileNames[imageIndex]);
            }

            ScrollButtonsConditioner();
        }

        private void ScrollButtonsConditioner()
        {
            if (fileNames == null)
            {
                fileNames = new string[1];
                fileNames[0] = openFilePath.Text;
            }
            else if (fileNames.Length <= 1) // only one file is selected
            {
                seeNextFile.Enabled = false;
                seePreviousFile.Enabled = false;
            }
            else if (imageIndex == 0) // first image
            {
                seePreviousFile.Enabled = false;
                seeNextFile.Enabled = true;
            }
            else if (imageIndex == fileNames.Length - 1) // last image
            {
                seeNextFile.Enabled = false;
                seePreviousFile.Enabled = true;
            }
            else
            {
                seeNextFile.Enabled = true;
                seePreviousFile.Enabled = true;
            }
        }
        #endregion


        #region Not using these yet

        private void label1_Click(object sender, EventArgs e)
        {
            //lll
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #region Showing image
        /// <summary>
        /// Every image goes through this method before being displayed
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public void ShowMeMyImage(string filePath)
        {
            //testLittleSquares.Clear();
            workingImage = Image.FromFile(filePath);
            Color usedColor = penColor;
            //csis = workingImage.Size;

            // resize the image (so they are all the same size)
            //workingImage = (Image)(new Bitmap(workingImage, new Size(400, 400)));

            if (convertToGray)
            {
                workingImage = Gray(workingImage);
                usedColor = Color.White;
            }

            if (showSquares)
            {
                graphics = Graphics.FromImage(workingImage);

                Brush brush = new SolidBrush(usedColor);
                Pen pen = new Pen(brush, penThickness);

                WhichOnesToOmit();

                int k = 0;  // Counter
                // Actually drawing the images
                for (int i = 0; i < noR; i++)
                {
                    for (int j = 0; j < noC; j++)
                    {
                        k++;

                        if (toOmitInt != null && toOmitInt.Any(n => n == k))
                            continue;

                        RectangleF rect = new RectangleF(spX + j * (soS + dbS), spY + i * (soS + dbS), soS, soS);
                        graphics.DrawRectangle(pen, rect);
                    }
                }
            }

            pictureBox1.Image = workingImage;
        }
        #endregion


        #region TextChanged of the Settings
        private void startPositionX_TextChanged(object sender, EventArgs e)
        {
            if (startPositionX.Text.Trim() != "")
                try
                {
                    spX = Convert.ToSingle(startPositionX.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);
        }


        private void startPositionY_TextChanged(object sender, EventArgs e)
        {
            if (startPositionY.Text.Trim() != "")
                try
                {
                    spY = Convert.ToSingle(startPositionY.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);
        }

        private void numOfRows_TextChanged(object sender, EventArgs e)
        {
            if (numOfRows.Text.Trim() != "")
                try
                {
                    noR = Convert.ToInt32(numOfRows.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);

        }

        private void numOfColumns_TextChanged(object sender, EventArgs e)
        {
            if (numOfColumns.Text.Trim() != "")
                try
                {
                    noC = Convert.ToInt32(numOfColumns.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);

        }

        private void squareSize_TextChanged(object sender, EventArgs e)
        {
            if (squareSize.Text.Trim() != "")
                try
                {
                    soS = Convert.ToSingle(squareSize.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);

        }

        private void distanceBetweenSqrs_TextChanged(object sender, EventArgs e)
        {
            if (distanceBetweenSqrs.Text.Trim() != "")
                try
                {
                    dbS = Convert.ToSingle(distanceBetweenSqrs.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(wrongInputSettings_message, wrongInputSettings_caption);
                }

            ShowMeMyImage(openFilePath.Text);

        }
        #endregion

        #region LostFocus Events
        private void startPositionX_Leave(object sender, EventArgs e)
        {
            if (startPositionX.Text.Trim() == "")
                startPositionX.Text = spX.ToString();
        }

        private void startPositionY_Leave(object sender, EventArgs e)
        {
            if (startPositionY.Text.Trim() == "")
                startPositionY.Text = spY.ToString();
        }

        private void numOfRows_Leave(object sender, EventArgs e)
        {
            if (numOfRows.Text.Trim() == "")
                numOfRows.Text = noR.ToString();
        }

        private void numOfColumns_Leave(object sender, EventArgs e)
        {
            if (numOfColumns.Text.Trim() == "")
                numOfColumns.Text = noC.ToString();
        }

        private void squareSize_Leave(object sender, EventArgs e)
        {
            if (squareSize.Text.Trim() == "")
                squareSize.Text = soS.ToString();
        }

        private void distanceBetweenSqrs_Leave(object sender, EventArgs e)
        {
            if (distanceBetweenSqrs.Text.Trim() == "")
                distanceBetweenSqrs.Text = dbS.ToString();
        }

        private void omitThese_Leave(object sender, EventArgs e)
        {
            if (omitThese.Text.Trim() == "")
                omitThese.Text = 0.ToString();
        }

        #endregion

        public void EditTextBoxValue(TextBox textBox, float value)
        {
            var temp = Convert.ToSingle(textBox.Text);
            temp += value;
            textBox.Text = temp.ToString();
        }

        #region Increase/Decrease Buttons
        private void decreaseRowNo_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(numOfRows, -noRDecStep);
        }

        private void increaseRowNo_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(numOfRows, noRIncStep);
        }

        private void decreaseColNo_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(numOfColumns, -noCDecStep);
        }

        private void increaseColNo_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(numOfColumns, noCIncStep);
        }

        private void decreaseSquareSize_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(squareSize, -soSDecStep);
        }

        private void increaseSquareSize_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(squareSize, soSIncStep);
        }

        private void decreaseDistBS_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(distanceBetweenSqrs, -dbSDecStep);
        }

        private void increaseDistBS_Click(object sender, EventArgs e)
        {
            EditTextBoxValue(distanceBetweenSqrs, dbSIncStep);
        }

        #endregion

        #region "Omit These" section
        private void showSquaresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showSquares = showSquaresCheckBox.Checked;
            ShowMeMyImage(openFilePath.Text);
        }

        public void WhichOnesToOmit()
        {
            // Could've done it like this too:
            //StringSplitOptions options = StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries;
            if (omitThese.Text != "")
                toOmitStr = omitThese.Text.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            else
                return;


            toOmitInt = new int[toOmitStr.Length];

            for (int i = 0; i < toOmitStr.Length; i++)
                try
                {
                    toOmitInt[i] = Convert.ToInt32(toOmitStr[i]);
                }
                catch (Exception)
                {
                    //MessageBox ms = Message.Create(Handle,"message");
                    continue;
                }
        }

        private void omitThese_TextChanged(object sender, EventArgs e)
        {
            ShowMeMyImage(openFilePath.Text);
        }
        #endregion

        #region Convert to Gray
        private void convertImageToGray_CheckedChanged(object sender, EventArgs e)
        {
            convertToGray = convertImageToGray.Checked;
            ShowMeMyImage(openFilePath.Text);
        }

        private Image Gray(Image image)
        {
            Bitmap btmp = new Bitmap(image);
            Color c;

            for (int i = 0; i < btmp.Width; i++)
            {
                for (int j = 0; j < btmp.Height; j++)
                {
                    c = btmp.GetPixel(i, j);

                    byte gray = (byte)(.299 * c.R + 0.587 * c.G + 0.114 * c.B);

                    btmp.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            return (Image)btmp.Clone();
        }
        #endregion

        #region Counting the squares

        private void StartCounting()
        {
            EnableControls(0);

            int imagesCount = fileNames.Length;
            int rowCount = (int)(imagesCount / imagesOfAKind + imagesCount + 1);

            string[] result_1 = new string[rowCount]; // 1'st table with averages and stuff
            string[] result_2 = new string[rowCount]; // 2'nd table which is kind of a summary
            string[] result_3 = new string[imagesCount + 1]; // 3'rd table just a raw set of data

            float[,] values = new float[rowCount + 2, noR * noC + noR + 2];

            #region Creating headers for second file/table
            result_2[0] += " ,";
            for (int i = 1; i <= noR; i++)
            {
                result_2[0] += $"TOTAL, R{i}, PERCENTAGE,";
            }
            #endregion

            int l = 0; // counts number of squares of each image (not considering the omitted ones)
            int m = 0; // correct counter of number of images
            int n = 0; // exact counter of number of actual squares in each image
            int sumImageRow = 0;
            int numOfDataInThisRow = 0;
            float sumOfThisRow = 0;
            bool attadim = false;

            for (int i = 0; i < rowCount; i++) // for each image
            {

                // Setting file names as row names of first file
                if (i != 0 && (m % imagesOfAKind != 0 || attadim)) // first row is header
                {
                    // extract data from images
                    string tfn = ThisFileName(fileNames[m]);

                    // making it a little bit nicer visually
                    while (tfn.Length < desiredLength)
                        tfn += " ";

                    tfn += ",";

                    // first cell is file name
                    result_1[i] += tfn;
                    result_2[m + 1] += tfn;
                    result_3[m + 1] += tfn;


                    attadim = false;
                }
                else
                {
                    // claculate the averages and stuff
                    result_1[i] += " ,";
                    attadim = true;
                }


                for (int j = 0; j < noR; j++) // each row
                {
                    for (int k = 0; k < noC; k++) // each column
                    {
                        l++;

                        if (toOmitInt != null && toOmitInt.Any(n => n == l)) // omit this
                        {
                            result_1[0] += "";
                        } // Omit These
                        else if (i == 0)    // Headers
                        {
                            // first Table
                            if (j == 0)
                                result_1[0] += $"R{j + 1}-{k},";
                            else
                                result_1[0] += $"R{j + 1}-{k + 1},";

                        }// Headers
                        else if (attadim && i != 0)   // time for average calculation!
                        {
                            float temp = values[i - 1, l] + values[i - 2, l] + values[i - 3, l];
                            result_1[i] += (100 * temp / imagesOfAKind).ToString("0.00") + ",";

                            sumOfThisRow += (temp / imagesOfAKind) * 100;
                            numOfDataInThisRow++;
                        } // Averages
                        else // storing actual square data both for displaying(result[i]) and calculations(Values[i,l])
                        {
                            values[i, l] = (float)ThisSquareValue(fileNames[m], j, k);
                            result_1[i] += values[i, l].ToString() + ",";
                            result_3[m + 1] += values[i, l].ToString() + ",";
                            sumImageRow += (int)values[i, l];
                            n++;
                        }   // Data From Images
                    }


                    if (i != 0 && !attadim) // creating second file
                    {
                        string temp = $"{n},{sumImageRow}," + ((float)sumImageRow * 100 / n).ToString("00.00");

                        while (temp.Length < 10) // making it visually nice!
                            temp += " ";

                        result_2[m + 1] += temp + ",";
                        sumImageRow = 0;
                        n = 0;
                    }// creating second file

                    if (attadim && i != 0)  // average of all data in one row
                    {
                        result_1[i] += "  " + (sumOfThisRow / numOfDataInThisRow).ToString("0.00") + "  ,";
                        sumOfThisRow = 0;
                        numOfDataInThisRow = 0;
                    }// average of all data in one row
                    else
                        result_1[i] += " ,";

                    if (!attadim && i != 0)  // 3'rd table
                        result_3[m + 1] += " ,";

                }


                l = 0;
                if (!attadim)
                    m++;

                // Progress bar
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        if ((100 * (m + 1) / fileNames.Count()) < 100)
                        {
                            progressBar1.Value = 100 * (m + 1) / fileNames.Count();
                            progressbarDoneImages.Text = "(" + (m + 1).ToString();
                            progressbarDoneImages.Update();
                        }
                        else
                        {
                            progressBar1.Value = 100;
                            progressbarDoneImages.Text = "(" + fileNames.Count().ToString();
                        }
                    });
                }
                else
                {
                    if ((100 * (m + 1) / fileNames.Count()) < 100)
                    {
                        progressBar1.Value = 100 * (m + 1) / fileNames.Count();
                        progressbarDoneImages.Text = "(" + (m + 1).ToString();
                        progressbarDoneImages.Update();
                    }
                    else
                    {
                        progressBar1.Value = 100;
                        progressbarDoneImages.Text = "(" + fileNames.Count().ToString();
                    }
                }

            }

            // headers for 3'rd table
            result_3[0] = result_1[0];

            // Saving
            try
            {
                File.WriteAllLines(saveAddress_1, result_1);
                File.WriteAllLines(saveAddress_2, result_2);
                File.WriteAllLines(saveAddress_3, result_3);
            }
            catch (Exception)
            {
                MessageBox.Show("\tSonucları Yazabilmədık... Niyə Görən", "Ax Boyunum...");
            }


            MessageBox.Show("\tQurtuldu.", "İşiz Hara Çatdi?");


            // Open the created files
            Process.Start("notepad.exe", saveAddress_1);
            Process.Start("notepad.exe", saveAddress_2);
            Process.Start("notepad.exe", saveAddress_3);


            EnableControls(1);
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (saveAddress_1.Trim() != "")
            {
                ProgressbarVisiblitiy(1);

                // *** Working on the main thread *** //
                //StartCounting();

                // *** calculation has it's own thread *** //
                calculatorThread = new Thread(StartCounting);
                calculatorThread.Start();
            }
            else
                MessageBox.Show("Birincısı, Sonucları Saxlamaq Üçün Bir Yer Seç", "Harada Saxlıyak Bıları İndı Biz?");

        }

        private string ThisFileName(string filePath)
        {
            return filePath.Split('\\').Last();
        }

        private string ThisFileExtention(string filePath)
        {
            return filePath.Split('.').Last();
        }

        private int ThisSquareValue(string fileAddress, int i, int j)
        {
            // Without resizing
            Bitmap btmp = new Bitmap(fileAddress);

            // Resizing the image
            //Image tmpImage = Image.FromFile(fileAddress);
            //Bitmap btmp = new Bitmap(tmpImage, (fis + csis)/2);
            //tmpImage.Dispose();

            RectangleF rect = new RectangleF(spX + j * (soS + dbS), spY + i * (soS + dbS), soS, soS);

            Bitmap square = btmp.Clone(rect, btmp.PixelFormat);

            Color c = new Color();
            float r = 122, g = 122, b = 122;
            int increment = (int)(soS / 4);
            int startPixel = (int)(increment / 2);
            int counter = 0;
            for (int m = startPixel; m < square.Width; m += increment)
            {
                for (int n = startPixel; n < square.Height; n += increment)
                {
                    c = square.GetPixel(m, n);
                    r = (float)(r + c.R) / 2;
                    g = (float)(g + c.G) / 2;
                    b = (float)(b + c.B) / 2;

                    counter++;
                }
            }

            // testing the resulting pircutes
            if (!galmisdikQabaxdan)
            {
                testLittleSquares.Add((Image)square);
                galmisdikQabaxdan = true;
            }
            else
                galmisdikQabaxdan = false;


            if (r + g + b < 650) // not white. this square isn't white
                return 1;
            else                 // white.     this Square is white
                return 0;

        }

        private void picNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = (int)picNumUpDown.Value;
                testPicBox.Image = testLittleSquares[i];
            }
            catch (Exception)
            {
                picNumUpDown.Value = 0;
            }
        }

        /// <summary>
        /// determines the visiblity of progressbar and int's stuff 
        /// </summary>
        /// <param name="cond">1- visible, 0- not</param>
        public void ProgressbarVisiblitiy(int cond)
        {
            if (cond == 0) // not visible
            {
                progressBar1.Visible = false;
                progressbarDoneImages.Visible = false;
                progressbarTotalImages.Visible = false;
                progressbarLabel.Visible = false;
                progressbarSlash.Visible = false;
            }
            else if (cond == 1)// visible
            {
                progressbarLabel.Visible = true;
                progressbarTotalImages.Text = fileNames.Count().ToString() + ")";
                progressbarTotalImages.Visible = true;
                progressbarDoneImages.Text = "(" + 0.ToString();
                progressbarDoneImages.Visible = true;
                progressbarSlash.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Value = 1;
            }

            progressbarLabel.Update();
            progressbarTotalImages.Update();
            progressbarDoneImages.Update();
            progressbarSlash.Update();
            progressBar1.Update();
        }
        #endregion

        #region workflow Conducting (enabling and disabling controls)
        /// <summary>
        /// enables or disable a group of controls
        /// </summary>
        /// <param name="state">state. 0 -> disable, 1 -> enable</param>
        public void EnableControls(int state)
        {
            if (state == 0) // disable all but 3 controls
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        startPositionX.Enabled = false;
                        startPositionY.Enabled = false;

                        decreaseRowNo.Enabled = false;
                        numOfRows.Enabled = false;
                        increaseRowNo.Enabled = false;

                        decreaseColNo.Enabled = false;
                        numOfColumns.Enabled = false;
                        increaseColNo.Enabled = false;

                        decreaseSquareSize.Enabled = false;
                        squareSize.Enabled = false;
                        increaseSquareSize.Enabled = false;

                        decreaseDistBS.Enabled = false;
                        distanceBetweenSqrs.Enabled = false;
                        increaseDistBS.Enabled = false;

                        omitThese.Enabled = false;

                        browsImages.Enabled = false;
                        saveButton.Enabled = false;
                        okButton.Enabled = false;

                        saveFilePath.Enabled = false;

                        convertImageToGray.Enabled = false;
                        showSquaresCheckBox.Enabled = false;
                    });
                }
                else
                {
                    startPositionX.Enabled = false;
                    startPositionY.Enabled = false;

                    decreaseRowNo.Enabled = false;
                    numOfRows.Enabled = false;
                    increaseRowNo.Enabled = false;

                    decreaseColNo.Enabled = false;
                    numOfColumns.Enabled = false;
                    increaseColNo.Enabled = false;

                    decreaseSquareSize.Enabled = false;
                    squareSize.Enabled = false;
                    increaseSquareSize.Enabled = false;

                    decreaseDistBS.Enabled = false;
                    distanceBetweenSqrs.Enabled = false;
                    increaseDistBS.Enabled = false;

                    omitThese.Enabled = false;

                    browsImages.Enabled = false;
                    saveButton.Enabled = false;
                    okButton.Enabled = false;

                    saveFilePath.Enabled = false;

                    convertImageToGray.Enabled = false;
                    showSquaresCheckBox.Enabled = false;
                }

                /*
                foreach (Control item in this.Controls)
                {
                    if (item.Name == "browsImages" || item.Name == "openFilePath" || item.Name == "exitButton")
                        item.Enabled = true;
                    else
                        item.Enabled = false;
                }
                */
            }
            else if (state == 1) // enable all controls
            {
                foreach (Control item in this.Controls)
                {
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            item.Enabled = true;
                        });
                    }
                    else
                        item.Enabled = true;

                }
            }
        }

        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Saving
        /* No using this anymore
        public void Save(string[] data_1, string[] data_2)
        {
            try
            {
                File.WriteAllLines(saveAddress_1, data_1);
                File.WriteAllLines(saveAddress_2, data_2);
            }
            catch (Exception)
            {
                MessageBox.Show("\tSonucları Yazabilmədık... Niyə Görən", "Ax Boyunum...");
            }

            //MessageBox.Show("\tYazdık Sonucları.", "Oldu!...");

        }
        */

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.AddToRecent = true;
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFilePath.Text = saveFileDialog.FileName;
            }
            else
                MessageBox.Show("Sən Bir Dolan Gənə Gəl Diyiren?", "Bir Yer Seçmədin");
        }

        private void saveFilePath_TextChanged(object sender, EventArgs e)
        {
            saveAddress_1 = saveFilePath.Text;

            string temp = saveFilePath.Text.Split('\\').Last().Split('.').First();
            saveAddress_2 = saveFilePath.Text.Replace(temp, temp + "_ikiminci");
            saveAddress_3 = saveFilePath.Text.Replace(temp, temp + "_yavan");
        }
        #endregion

        #region MenuStrip 'n Stuff
        private void bizaGoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup popup = new popup();
            popup.ShowDialog();
        }

        private void qələmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form penSettingsForm = new PenSettings();
            penSettingsForm.ShowDialog();

            /*
            MessageBox.Show(
                "Başda bir qələm qurabilmək yerı qoymağı düşünürdüm...\n" +
                "Amma sora gördüm neynır...\n" +
                "Gavar gələn sürümlərdə.",
                "Qələmı Qur (-a bilmə)");
            */
        }
        #endregion

        #region Drag and Drop

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // Save current colors
            form1Color = this.BackColor;
            menuStrip1Color = menuStrip1.BackColor;

            // Set new colors
            this.BackColor = Color.AliceBlue;
            menuStrip1.BackColor = Color.AliceBlue;


            e.Effect = DragDropEffects.Copy;
        }


        private void Form1_DragLeave(object sender, EventArgs e)
        {
            // Revert changed colors
            this.BackColor = form1Color;
            menuStrip1.BackColor = menuStrip1Color;
        }


        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            tempDragedFiles.Clear();

            var tempFiles = (string[])e.Data.GetData(DataFormats.FileDrop);


            // select the suitable file (image files)
            foreach (var item in tempFiles)
            {
                string a = ThisFileExtention(item).ToLower();
                if (a == "png" || a == "jpg" || a == "gif")
                    tempDragedFiles.Add(item);
            }

            dragedFiles = tempDragedFiles.ToArray();
            fileNames = tempDragedFiles.ToArray();

            if (dragedFiles == null || dragedFiles.Count() == 0)
                MessageBox.Show("Bı(lar) .png, .jpg yoxsa .gif döül(lər)", "Pis Seçdin");

            WeHaveImagesNow(tempDragedFiles.ToArray());

            // Revert changed colors
            this.BackColor = form1Color;
            menuStrip1.BackColor = menuStrip1Color;
        }

        #endregion

        #region Special Case Handling
        private void UnconsistentImageSize_Click(object sender, EventArgs e)
        {
            Form imNosely01 = new imNosely01();
            imNosely01.Show();
        }

        private void ImagesNotTriple_Click(object sender, EventArgs e)
        {
            Form imNosely02 = new imNosely02();
            imNosely02.Show();
        }

        #endregion

        #region Language Settings

        private void Dil_English_US_Click(object sender, EventArgs e)
        {
            ChangeLanguage.ToEnglishUS();
        }

        private void Dil_Turku_AZ_Click(object sender, EventArgs e)
        {
            ChangeLanguage.ToTurkuAzerbaycan();
        }

        private void englishUSSeriouslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage.ToEnglishUK();
        }
        #endregion
    }
}
