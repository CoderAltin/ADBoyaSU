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
            Image image1 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (1).jpg");
            Image image2 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (2).jpg");
            Image image3 = Image.FromFile(@"G:\B\University\Undergraduate n Sftwrs n Ppr\Programming\C#\Projects\Sonaz\dadaslar\Revision 02- Parlax C inan Parlax C Ornaklari\initial-ts\tsek (3).jpg");


            dataGridView1.Rows.Add(new object[] { "Altin", image1, image2, image3, "CA = 86\nCp = 37\nCC = 98" });
            dataGridView1.Rows.Add(new object[] { "Elgar", image1, image2, image3, "CA = 10\nCp = 20\nCC = 30" });
            dataGridView1.Rows.Add(new object[] { "Ersan", image1, image2, image3, "CA = 92\nCp = 38\nCC = 34" });
        }


    }
}
