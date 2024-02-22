using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBoyaSU
{
    internal class imageManipulation
    {
        public Image workingImage;

        public Image CreateImage(string filePath)
        {
            workingImage = Image.FromFile(filePath);
            return workingImage;
        }
    }
}
