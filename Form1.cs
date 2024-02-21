using SixLabors.ImageSharp;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;

namespace ADBoyaSU
{
    public partial class Form1 : Form
    {
        
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "image files|*.png;*.jpg;*.gif";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            // assign fileNames to images stored in the list
            List<System.Drawing.Image>? imageList = new List<System.Drawing.Image>();

            for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                imageList.Add(System.Drawing.Image.FromFile(openFileDialog.FileNames[i]));

            // Dispaly images in the picuteBox1
            pictureBox1.Image = imageList[0];
        }
    }
}
