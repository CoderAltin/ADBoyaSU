//using SixLabors.ImageSharp;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;

namespace ADBoyaSU
{
    public partial class Form1 : Form
    {
        Image workingImage;
        Graphics graphics;

        OpenFileDialog openFileDialog = new OpenFileDialog();

        public int imageIndex = 0;
        public string currentFilePath;

        imageManipulation IM = new imageManipulation();

        public int spX = 10; // starting point x
        public int spY = 10; // starting point y
        public int noR = 3; // number of rows
        public int noC = 5; // number of columns
        public int soS = 10; // size of squares
        public int dbS = 2; // distance between squares





        public Form1()
        {
            InitializeComponent();

        }

        private void browsImages_Click(object sender, EventArgs e)
        {
            // Selecting the image
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "image files|*.png;*.jpg;*.gif";
            DialogResult dialogResult = openFileDialog.ShowDialog();


            // Dispaly images in the picuteBox1
            //seeNextFile.Enabled = true;
            imageIndex = 0;
            SelectImage(0);
        }

        public void SelectImage(int direction)
        {
            if (direction == 0)
                currentFilePath = openFileDialog.FileNames[imageIndex];
            else if (direction == 1 && ++imageIndex <= openFileDialog.FileNames.Length - 1)
                currentFilePath = openFileDialog.FileNames[imageIndex];
            else if (direction == -1 && --imageIndex >= 0)
                currentFilePath = openFileDialog.FileNames[imageIndex];


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
            else if (imageIndex == 0)
            {
                seePreviousFile.Enabled = false;
                seeNextFile.Enabled = true;
            }
            else if (imageIndex == openFileDialog.FileNames.Length - 1)
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
            workingImage = Image.FromFile(filePath);
            graphics = Graphics.FromImage(workingImage);

            Brush brush = new SolidBrush(Color.DarkViolet);
            Pen pen = new Pen(brush, 5f);

            for (int i = 0; i < noR; i++)
            {
                for (int j = 0; j < noC; j++)
                {
                    Rectangle rect = new Rectangle(spX + j * (soS + dbS), spY + i * (soS + dbS), soS, soS);
                    graphics.DrawRectangle(pen, rect);
                }
            }
            //Rectangle rect = new Rectangle(100, 100, 150, 150);
            //graphics.DrawRectangle(pen, rect);

            pictureBox1.Image = workingImage;
            //return workingImage;
        }

        private void startPositionX_TextChanged(object sender, EventArgs e)
        {
            if (startPositionX.Text != "")
                spX = Convert.ToInt32(startPositionX.Text);
            
            ShowMeMyImage(openFilePath.Text);
        }

        private void startPositionY_TextChanged(object sender, EventArgs e)
        {
            if (startPositionY.Text != "")
                spY = Convert.ToInt32(startPositionY.Text);

            ShowMeMyImage(openFilePath.Text);
        }

        private void numOfRows_TextChanged(object sender, EventArgs e)
        {
            noR = Convert.ToInt32(numOfRows.Text);
            ShowMeMyImage(openFilePath.Text);

        }

        private void numOfColumns_TextChanged(object sender, EventArgs e)
        {
            noC = Convert.ToInt32(numOfColumns.Text);
            ShowMeMyImage(openFilePath.Text);

        }

        private void squareSize_TextChanged(object sender, EventArgs e)
        {
            soS = Convert.ToInt32(squareSize.Text);
            ShowMeMyImage(openFilePath.Text);

        }

        private void distanceBetweenSqrs_TextChanged(object sender, EventArgs e)
        {
            dbS = Convert.ToInt32(distanceBetweenSqrs.Text);
            ShowMeMyImage(openFilePath.Text);

        }
    }
}
