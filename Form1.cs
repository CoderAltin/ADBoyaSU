using SixLabors.ImageSharp;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;

namespace ADBoyaSU
{
    public partial class Form1 : Form
    {
        public int imageIndex = 0;
        OpenFileDialog openFileDialog = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();

        }

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

        private void browsImages_Click(object sender, EventArgs e)
        {
            // Selecting the image
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "image files|*.png;*.jpg;*.gif";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            // assign fileNames to images stored in the list

            // Dispaly images in the picuteBox1
            seeNextFile.Enabled = true;
            imageIndex = 0;
            ShowSelectedImage(0);
            //pictureBox1.Image = imageList[0];
        }

        //public void ShowSelectedImage(string direction, OpenFileDialog openFileDialog)
        public void ShowSelectedImage(int direction)
        {
            if (direction == 0)
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileNames[imageIndex]);

            else if (direction == 1 && ++imageIndex <= openFileDialog.FileNames.Length - 1)
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileNames[imageIndex]);

            else if (direction == -1 && --imageIndex >= 0)
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileNames[imageIndex]);

            openFilePath.Text = openFileDialog.FileNames[imageIndex];

            if (imageIndex == 0)
                seePreviousFile.Enabled = false;
            else if (imageIndex == openFileDialog.FileNames.Length - 1)
                seeNextFile.Enabled = false;
            else
            {
                seeNextFile.Enabled = true;
                seePreviousFile.Enabled = true;
            }
        }

        private void seePreviousFile_Click(object sender, EventArgs e)
        {
            ShowSelectedImage(-1);
        }

        private void seeNextFile_Click(object sender, EventArgs e)
        {
            ShowSelectedImage(1);
        }
    }
}
