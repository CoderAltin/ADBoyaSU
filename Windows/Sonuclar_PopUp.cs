using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBoyaSU.Windows
{
    public partial class Sonuclar_PopUp : Form
    {
        public int i = 0;
        public Sonuclar_PopUp()
        {
            InitializeComponent();

            //PopulateSomeData();
        }

        public void AddThisToSonucWind(string image1Name, string image2Name, string image3Name, float CA, float CC, float CP)
        {
            string name1 = image1Name.Split('\\').Last().Split('.').First();
            string name2 = image2Name.Split('\\').Last().Split('.').First();
            string name3 = image3Name.Split('\\').Last().Split('.').First();

            Size groupBoxSize = new Size(760, 200);
            int distFromBorder = 6;
            // create different component of window
            GroupBox groupBox = new GroupBox();
            groupBox.Size = groupBoxSize;
            groupBox.Location = new Point(distFromBorder, i * (groupBoxSize.Height + distFromBorder) + distFromBorder);
            groupBox.Text = name1;



            // Add created control to the window
            tabPage3.Controls.Add(groupBox);

            i++; // n'th file (used for positioning controls)
        }

        public void ClearThis()
        {
            tabPage3.Controls.Clear();
        }

        private void PopulateSomeData()
        {
            //
            // Tab Page 1
            #region Tab Page 1

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
            #endregion


            //
            // Tab Page 3
            #region Tab Page 2

            // Images
            //
            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;

            int groupBoxCount = 1;
            GroupBox[] groupBoxes = new GroupBox[groupBoxCount];

            for (int i = 0; i < groupBoxCount; i++)
            {
                groupBoxes[i] = new GroupBox();
                Name = $"groupBox{i + 2}";

                groupBoxes[i].Text = $"Test GroupBox {i}";
                groupBoxes[i].Size = new Size(756, 202);
                groupBoxes[i].Location = new Point(6, 202 * (2 + i) + 6 * (3 + i));

                Label lbl = new Label();
                lbl.Text = "test lable";
                lbl.Size = new Size(150, 35);
                lbl.Font = new Font(FontFamily.GenericSansSerif, 20);
                lbl.Location = new Point(6, 30);
                lbl.BorderStyle = BorderStyle.FixedSingle;

                groupBoxes[i].Controls.Add(lbl);

                tabPage3.Controls.Add(groupBoxes[i]);
            }
            #endregion

        }
    }
}
