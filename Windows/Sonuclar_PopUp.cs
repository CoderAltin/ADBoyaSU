using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBoyaSU.Windows
{
    public partial class Sonuclar_PopUp : Form
    {
        public Sonuclar_PopUp()
        {
            InitializeComponent();

            PopulateSomeData();
        }

        private void PopulateSomeData()
        {
            //
            // Data Grid View
            //
            Image image1 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (1).jpg");
            Image image2 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (2).jpg");
            Image image3 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (3).jpg");

            // Resize images
            Size size = new Size(250, 250);
            var image1Resize = (Image)new Bitmap(image1, size);
            var image2Resize = (Image)new Bitmap(image2, size);
            var image3Resize = (Image)new Bitmap(image3, size);

            // Create new rows
            dataGridView1.Rows.Add(new object[] { "Altin", image1Resize, image2Resize, image3Resize, "CA = 0.99973917 \nCp = 0.9539506  \nCC = 0.86608    " });
            dataGridView1.Rows.Add(new object[] { "Elgar", image1Resize, image2Resize, image3Resize, "CA = 0.99903214 \nCp = 0.9515916  \nCC = 0.8326157  " });
            dataGridView1.Rows.Add(new object[] { "Ersan", image1Resize, image2Resize, image3Resize, "CA = 0.9994888  \nCp = 0.96355563 \nCC = 0.87470895 " });

            /*dataGridView1.Rows.Add(new object[] { "Altin", image1Resize, image2Resize, image3Resize, "CA = 86\nCp = 37\nCC = 98" });
            dataGridView1.Rows.Add(new object[] { "Elgar", image1, image2, image3, "CA = 10\nCp = 20\nCC = 30" });
            dataGridView1.Rows.Add(new object[] { "Ersan", image1, image2, image3, "CA = 92\nCp = 38\nCC = 34" });*/


            //
            // Images
            //
            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;
        }
    }
}
