//using SixLabors.ImageSharp;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace ADBoyaSU
{
    public partial class Form1 : Form
    {
        // Azərbaycan Hərflərı:
        // Ü İ Ö Ğ I Ə Ç Ş
        // ü i ö ğ ı ə ç ş

        public bool convertToGray = false;
        public bool showSquares = true;
        Image workingImage;
        Graphics graphics;

        OpenFileDialog openFileDialog = new OpenFileDialog();

        public int imageIndex = 0;
        public string currentFilePath;

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

        public string[] toOmitStr;
        public int[]? toOmitInt;

        // ThisSquareValue
        int imagesOfAKind = 3;  // number of images that represent same sound
        List<Image> testLittleSquares = new List<Image>();
        //Image[] testLittleSquares;
        bool galmisdikQabaxdan = false;

        public Form1()
        {
            InitializeComponent();
            noR = Convert.ToInt32(numOfRows.Text);
            noC = Convert.ToInt32(numOfColumns.Text);

            //testLittleSquares = new Image[noR * noC + 1];
        }

        private void browsImages_Click(object sender, EventArgs e)
        {
            // Selecting the image
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "image files|*.png;*.jpg;*.gif";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            allImagesCount.Text = openFileDialog.FileNames.Count().ToString();

            // Dispaly images in the picuteBox1
            imageIndex = 0;
            SelectImage(0);

            // Hide the progressbar
            progressBar1.Visible = false;
        }

        public void SelectImage(int direction)
        {
            if (direction == 0)
            {
                currentFilePath = openFileDialog.FileNames[imageIndex];
                thisImageIndex.Text = (imageIndex + 1).ToString();
            }
            else if (direction == 1 && ++imageIndex <= openFileDialog.FileNames.Length - 1)
            {
                currentFilePath = openFileDialog.FileNames[imageIndex];
                thisImageIndex.Text = (imageIndex + 1).ToString();

            }
            else if (direction == -1 && --imageIndex >= 0)
            {
                currentFilePath = openFileDialog.FileNames[imageIndex];
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
            }
            catch (FileNotFoundException)
            {
                pictureBox1.Image = null;
            }
            catch (Exception)
            {
                ShowMeMyImage(openFileDialog.FileNames[imageIndex]);

                //throw;
            }

            ScrollButtonsConditioner();
        }

        private void ScrollButtonsConditioner()
        {
            if (openFileDialog.FileNames.Length <= 1) // only one file is selected
            {
                seeNextFile.Enabled = false;
                seePreviousFile.Enabled = false;
            }
            else if (imageIndex == 0) // first image
            {
                seePreviousFile.Enabled = false;
                seeNextFile.Enabled = true;
            }
            else if (imageIndex == openFileDialog.FileNames.Length - 1) // last image
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

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        /// <summary>
        /// Close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Every image goes through this method before being displayed
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public void ShowMeMyImage(string filePath)
        {
            //testLittleSquares.Clear();
            workingImage = Image.FromFile(filePath);

            if (convertToGray)
            {
                workingImage = Gray(workingImage);
            }

            if (showSquares)
            {
                graphics = Graphics.FromImage(workingImage);

                Brush brush = new SolidBrush(penColor);
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
                    MessageBox.Show("\tBir Sayı Yaz", "Savadsız");
                }

            ShowMeMyImage(openFilePath.Text);
        }

        private void startPositionY_TextChanged(object sender, EventArgs e)
        {
            if (startPositionY.Text.Trim() != "")
                spY = Convert.ToSingle(startPositionY.Text);

            ShowMeMyImage(openFilePath.Text);
        }

        private void numOfRows_TextChanged(object sender, EventArgs e)
        {
            if (numOfRows.Text.Trim() != "")
                noR = Convert.ToInt32(numOfRows.Text);

            ShowMeMyImage(openFilePath.Text);

        }

        private void numOfColumns_TextChanged(object sender, EventArgs e)
        {
            if (numOfColumns.Text.Trim() != "")
                noC = Convert.ToInt32(numOfColumns.Text);

            ShowMeMyImage(openFilePath.Text);

        }

        private void squareSize_TextChanged(object sender, EventArgs e)
        {
            if (squareSize.Text.Trim() != "")
                soS = Convert.ToSingle(squareSize.Text);
            ShowMeMyImage(openFilePath.Text);

        }

        private void distanceBetweenSqrs_TextChanged(object sender, EventArgs e)
        {
            if (distanceBetweenSqrs.Text.Trim() != "")
                dbS = Convert.ToSingle(distanceBetweenSqrs.Text);
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
            int imagesCount = openFileDialog.FileNames.Length;
            int rowCount = (int)(imagesCount / imagesOfAKind + imagesCount + 1);
            string[] result = new string[rowCount];
            float[,] values = new float[rowCount + 2, noR * noC + noR + 2];


            int l = 0;
            int m = 0;
            int numOfDataInThisRow = 0;
            float sumOfThisRow = 0;
            bool attadim = false;
            for (int i = 0; i < rowCount; i++) // for each image
            {
                if (i != 0 && (m % imagesOfAKind != 0 || attadim)) // first row is header
                {
                    // extract data from images

                    result[i] += ThisFileName(openFileDialog.FileNames[m]) + " ,"; // first cell is file name

                    attadim = false;
                }
                else
                {
                    // claculate the averages and stuff
                    result[i] += " ,";
                    attadim = true;
                }


                for (int j = 0; j < noR; j++) // each row
                {
                    for (int k = 0; k < noC; k++) // each column
                    {
                        l++;

                        if (toOmitInt != null && toOmitInt.Any(n => n == l)) // omit this
                            result[0] += "";
                        else if (i == 0)    // Headers
                        {
                            if (j == 0)
                                result[0] += $"R{j + 1}-{k},";
                            else
                                result[0] += $"R{j + 1}-{k + 1},";
                        }
                        else if (attadim && i != 0)   // time for average calculation!
                        {
                            float temp = values[i - 1, l] + values[i - 2, l] + values[i - 3, l];
                            result[i] += (100 * temp / imagesOfAKind).ToString() + ",";

                            sumOfThisRow += (temp / imagesOfAKind) * 100;
                            numOfDataInThisRow++;
                        }
                        else
                        {
                            result[i] += ThisSquareValue(openFileDialog.FileNames[m], j, k).ToString() + ",";
                            values[i, l] = (float)ThisSquareValue(openFileDialog.FileNames[m], j, k);
                        }
                    }

                    if (attadim && i != 0)
                    {
                        result[i] += "  " + (sumOfThisRow / numOfDataInThisRow).ToString() + "  ,";
                        sumOfThisRow = 0;
                        numOfDataInThisRow = 0;
                    }
                    else
                        result[i] += " ,";
                }

                l = 0;
                if (!attadim)
                    m++;

                // Progress bar
                if ((100 * (m + 1) / openFileDialog.FileNames.Count()) < 100)
                    progressBar1.Value = 100 * (m + 1) / openFileDialog.FileNames.Count();
                else
                    progressBar1.Value = 100;
            }

            string tempPath = "C:\\Users\\Altin\\Pictures\\test.txt";
            File.WriteAllLines(tempPath, result);
            //File.Open(tempPath,FileMode.OpenOrCreate);

            MessageBox.Show("\tQurtuldu", "Bildirim");

            progressBar1.Value = 0;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 1;

            StartCounting();
        }

        private string ThisFileName(string filePath)
        {
            return filePath.Split('\\').Last();
        }

        private int ThisSquareValue(string fileAddress, int i, int j)
        {
            Bitmap btmp = new Bitmap(fileAddress);
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

        #endregion

    }
}
