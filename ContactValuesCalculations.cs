using SixLabors.ImageSharp.PixelFormats;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        public static float[] ThisSoundResults(int[,] a1, int[,] a2, int[,] a3)
        {
            float[] results = new float[3];

            // Rn's and Cn's for a1
            float[] a1rn = Rn(a1);
            float[] a1cn = Cn(a1);
            // Rn's and Cn's for a2
            float[] a2rn = Rn(a2);
            float[] a2cn = Cn(a2);
            // Rn's and Cn's for a3
            float[] a3rn = Rn(a1);
            float[] a3cn = Cn(a3);

            // averages of Rn's and Cn's for all of them
            float[] RN = new float[a1rn.GetLength(0)];
            float[] CN = new float[a1cn.GetLength(0)];

            for (int i = 0; i < RN.Length; i++)
            {
                RN[i] = (a1rn[i] + a2rn[i] + a3rn[i]) / 3;
            }

            for (int i = 0; i < CN.Length; i++)
            {
                CN[i] = (a1cn[i] + a2cn[i] + a3cn[i]) / 3;
            }

            // results[1] => CA 
            results[1] = CA(RN);
            // results[2] => CP
            results[2] = CP(RN);
            // results[3] => CC
            results[3] = CC(CN);

            return results;
        }

        // Change the percision (float, double, long) if you like later.

        public static float CA(float[] RN)
        {
            float temp = MathF.Log10((RN[7] + (9 * RN[6]) + (81 * RN[5]) + (729 * RN[4]) + (6561 * RN[3]) + (59049 * RN[2]) + (531441 * RN[1]) + (3587227 * RN[0])) + 1)
                / MathF.Log10(4185098 + 1);

            return temp;
        }
        public static float CA(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R8 + (9 * R7) + (81 * R6) + (729 * R5) + (6561 * R4) + (59049 * R3) + (531441 * R2) + (3587227 * R1)) + 1)
                / MathF.Log10(4185098 + 1);

            return temp;
        }


        public static float CP(float[] RN)
        {
            float temp = MathF.Log10((RN[0] + (9 * RN[1]) + (81 * RN[2]) + (729 * RN[3]) + (6561 * RN[4]) + (59049 * RN[5]) + (531441 * RN[6]) + (4782969 * RN[7])) + 1)
                / MathF.Log10(5380840 + 1);

            return temp;
        }
        public static float CP(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R1 + (9 * R2) + (81 * R3) + (729 * R4) + (6561 * R5) + (59049 * R6) + (531441 * R7) + (4782969 * R8)) + 1)
                / MathF.Log10(5380840 + 1);

            return temp;
        }


        public static float CC(float[] CN)
        {
            float temp = MathF.Log10(CN[0] + (17 * CN[1]) + (289 * CN[2]) + (4913 * CN[3]) + 1)
                / MathF.Log10(5220 + 1);

            return temp;
        }
        public static float CC(float C1, float C2, float C3, float C4)
        {
            float temp = MathF.Log10(C1 + (17 * C2) + (289 * C3) + (4913 * C4) + 1)
                / MathF.Log10(5220 + 1);

            return temp;
        }

        /// <summary>
        /// Calculate column averages
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static float[] Cn(int[,] a)
        {
            float[] result = new float[a.GetLength(1) / 2];
            float temp = 0;

            for (int i = 0; i < a.GetLength(1) / 2; i++) // Columns
            {
                for (int j = 0; j < a.GetLength(0); j++) // Rows
                {
                    temp += a[j, i] + a[j, a.GetLength(1) - 1 - i];
                }

                if (i == 0)
                    result[i] = temp / 14;
                else
                    result[i] = temp / 16;
            }

            return result;
        }

        /// <summary>
        /// Calculates row values average for an image
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static float[] Rn(int[,] a)
        {
            float[] result = new float[a.GetLength(0)];
            float temp = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    temp += a[i, j];
                }

                if (i == 0)
                    result[i] = temp / 6;
                else
                    result[i] = temp / 8;
            }

            return result;
        }

    }
}
