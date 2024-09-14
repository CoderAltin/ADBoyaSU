using SixLabors.ImageSharp.PixelFormats;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBoyaSU
{
    public static class ContactValuesCalculations
    {
        /*static int A = 1;
        static int B = 9;
        static int D = 81;
        static int E = 729;
        static int F = 6561;
        static int G = 59049;
        static int H = 531441;
        static int I = 4782969;*/

        // Change the percision (float, double, long) if you like later.

        public static float CA(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R8 + (9 * R7) + (81 * R6) + (729 * R5) + (6561 * R4) + (59049 * R3) + (531441 * R2) + (3587227 * R1)) + 1) 
                / MathF.Log10(4185098 + 1);

            return temp;
        }


        public static float CP(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R1 + (9*R2) + (81 * R3) + (729 * R4) + (6561 * R5) + (59049 * R6) + (531441 * R7) + (4782969 * R8)) + 1) 
                / MathF.Log10(5380840 + 1);

            return temp;
        }


    }
}
