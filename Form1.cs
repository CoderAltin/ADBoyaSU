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
            ShowSelectedImage(0);
        }

        public void ShowSelectedImage(int direction)
        {
            if (direction == 0)
                currentFilePath = openFileDialog.FileNames[imageIndex];
            else if (direction == 1 && ++imageIndex <= openFileDialog.FileNames.Length - 1)
                currentFilePath = openFileDialog.FileNames[imageIndex];
            else if (direction == -1 && --imageIndex >= 0)
                currentFilePath = openFileDialog.FileNames[imageIndex];


            //pictureBox1.Image = Image.FromFile(currentFilePath);
            //pictureBox1.Image = IM.CreateImage(currentFilePath);
            //pictureBox1.Image = GiveMeMyImage(currentFilePath);
            openFilePath.Text = currentFilePath;


            ScrollButtonsConditioner();

            // Test area
            workingImage = Image.FromFile(currentFilePath);
        }

        private void seePreviousFile_Click(object sender, EventArgs e)
        {
            ShowSelectedImage(-1);
        }

        private void seeNextFile_Click(object sender, EventArgs e)
        {
            ShowSelectedImage(1);
        }

        private void openFilePath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = GiveMeMyImage(openFilePath.Text);
            }
            catch (FileNotFoundException)
            {
                pictureBox1.Image = null;
            }
            catch (Exception)
            {
                pictureBox1.Image = GiveMeMyImage(openFileDialog.FileNames[imageIndex]);

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
        public Image GiveMeMyImage(string filePath)
        {
            workingImage = Image.FromFile(filePath);
            graphics = Graphics.FromImage(workingImage);

            Brush brush = new SolidBrush(Color.DarkViolet);
            Pen pen = new Pen(brush, 5f);
            Rectangle rect = new Rectangle(100, 100, 150, 150);

            graphics.DrawRectangle(pen, rect);

            return workingImage;
        }
    }
}
