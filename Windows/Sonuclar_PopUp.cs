using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.Loader;
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

        public void AddThisToSonucWind(string image1Address, string image2Address, string image3Address, float[] results)
        {
            string[] addresses = new string[3];
            addresses[0] = image1Address;
            addresses[1] = image2Address;
            addresses[2] = image3Address;

            string[] names = new string[3];
            names[0] = image1Address.Split('\\').Last().Split('.').First();
            names[1] = image2Address.Split('\\').Last().Split('.').First();
            names[2] = image3Address.Split('\\').Last().Split('.').First();

            string[] rns = { "CA", "CP", "CC" }; // result names


            Size groupBoxSize = new Size(760, 200);
            int distFromBorder = 6;

            PictureBox[] pictureBoxes = new PictureBox[3];
            Point pbStartLocation = new Point(48, 22);
            Size pbSize = new Size(150, 150);

            Label[] pictureLables = new Label[3];
            Point plStartLocation = new Point(0, pbStartLocation.Y + pbSize.Height + (int)distFromBorder / 2);

            Label[] resultNames = new Label[3];
            Point rnStartLocation = new Point(pbStartLocation.X + 3 * pbSize.Width + 3 * distFromBorder + distFromBorder, 40);
            Size rnSize = new Size(37, 28);

            Label[] resultValues = new Label[3];
            Point rvStartLocation = new Point(rnStartLocation.X + rnSize.Width + 3*distFromBorder, rnStartLocation.Y);



            // *** create different component of window *** //

            // Create GroupBox
            GroupBox groupBox = new GroupBox();
            groupBox.Size = groupBoxSize;
            groupBox.Location = new Point(distFromBorder, i * (groupBoxSize.Height + distFromBorder) + distFromBorder);
            groupBox.Text = names[0];


            // Create PictureBoxes, image names, result names and result values
            for (int j = 0; j < 3; j++)
            {
                int picLocX = pbStartLocation.X + j * (pbSize.Width + distFromBorder);
                pictureBoxes[j] = new PictureBox();
                //pictureBoxes[j].Name = $"picturebox{j}";
                pictureBoxes[j].Location = new Point(picLocX, pbStartLocation.Y);
                pictureBoxes[j].Size = pbSize;
                pictureBoxes[j].SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxes[j].Image = Image.FromFile(addresses[j]);


                pictureLables[j] = new Label();
                //pictureLables[j].Name = $"pictureLbel{j}";
                pictureLables[j].Location = new Point(picLocX, pbStartLocation.Y + pbSize.Height + 3);
                pictureLables[j].Text = names[j];


                resultNames[j] = new Label();
                int resLocY = rnStartLocation.Y + j * (resultNames[j].Size.Height + 2 * distFromBorder);
                resultNames[j].Font = new Font("Segoe UI", 15);
                resultNames[j].Size = rnSize;
                //resultNames[j].Name = $"resultName{j}";
                resultNames[j].Location = new Point(rnStartLocation.X, resLocY);
                resultNames[j].Text = rns[j];


                resultValues[j] = new Label();
                resultValues[j].Font = new Font("Segoe UI", 15);
                resultValues[j].Size = new Size(142, 38);
                //resultValues[j].Name = $"resultValue{j}";
                resultValues[j].Location = new Point(rvStartLocation.X, resLocY);
                resultValues[j].Text = results[j].ToString();


                // add control to Groupbox
                groupBox.Controls.Add(pictureBoxes[j]);
                groupBox.Controls.Add(pictureLables[j]);
                groupBox.Controls.Add(resultNames[j]);
                groupBox.Controls.Add(resultValues[j]);
            }



            // Add created control to the window
            //tabPage3.Controls.Add(groupBox);
            SonuclarPanel.Controls.Add(groupBox);

            i++; // n'th file (used for positioning controls)
        }

        public void ClearThis()
        {
            tabPage3.Controls.Clear();
            SonuclarPanel.Controls.Clear();
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
            #region Tab Page 3

            // Images
            //
            pictureBox4.Image = image1;
            pictureBox5.Image = image2;
            pictureBox6.Image = image3;

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
                //SonucPanel.Controls.Add(groupBoxes[i]);
            }
            #endregion

        }
    }
}
