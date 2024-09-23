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
        static int I_CA = 3587227;
        static int I_CP = 4782969;

        static int CA_Denominator = 4185098;
        static int CP_Denominator = 5380840;

        static int L = 1;
        static int M = 17;
        static int N = 289;
        static int O = 4913;

        static int CC_Denominator = 5220;*/


        /// <summary>
        /// Calculate CA, CP and CC values for one sound, represented by three images
        /// </summary>
        /// <param name="a1">a 2D array of values representing first image of the sound</param>
        /// <param name="a2">a 2D array of values representing second image of the sound</param>
        /// <param name="a3">a 2D array of values representing third image of the sound</param>
        /// <param name="contactPosteriority">Contact Posteriority</param>
        /// <param name="contactCentrality">Contact Centrality</param>
        /// <returns>Conact Anteriority of CA</returns>
        public static float ThisSoundResults(int[,] a1, int[,] a2, int[,] a3,out float contactPosteriority, out float contactCentrality)
        {
            float contactAnteriority = 0;

            // Rn's and Cn's for a1
            float[] a1rn = Rn(a1); // row averages for only the first image
            float[] a1cn = Cn(a1); // column averages for only the first image
            // Rn's and Cn's for a2
            float[] a2rn = Rn(a2); // row averages for only the second image
            float[] a2cn = Cn(a2); // column averages for only the second image
            // Rn's and Cn's for a3
            float[] a3rn = Rn(a1); // row averages for only the third image
            float[] a3cn = Cn(a3); // column averages for only the third image

            // averages of Rn's and Cn's for all of images
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


            contactAnteriority = CA(RN);
            contactPosteriority = CP(RN);
            contactCentrality = CC(CN);


            return contactAnteriority;
        }
        /// <summary>
        /// Calculate CA, CP and CC values for one sound, represented by three images
        /// </summary>
        /// <param name="a1">a 2D array of values representing first image of the sound</param>
        /// <param name="a2">a 2D array of values representing second image of the sound</param>
        /// <param name="a3">a 2D array of values representing third image of the sound</param>
        /// <returns></returns>
        public static float[] ThisSoundResults(int[,] a1, int[,] a2, int[,] a3)
        {
            float[] results = new float[3];

            // Rn's and Cn's for a1
            float[] a1rn = Rn(a1); // row averages for only the first image
            float[] a1cn = Cn(a1); // column averages for only the first image
            // Rn's and Cn's for a2
            float[] a2rn = Rn(a2); // row averages for only the second image
            float[] a2cn = Cn(a2); // column averages for only the second image
            // Rn's and Cn's for a3
            float[] a3rn = Rn(a3); // row averages for only the third image
            float[] a3cn = Cn(a3); // column averages for only the third image

            // averages of Rn's and Cn's for all of images
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


            results[0] = CA(RN);
            results[1] = CP(RN);
            results[2] = CC(CN);


            return results;
        }


        // Change the percision (float, double, long) if you like later.
        // Contact Anteriority
        /// <summary>
        /// Calculate Contact Anteriority based on provided averages
        /// </summary>
        /// <param name="RN">an array of averages for values in a row</param>
        /// <returns>CA Value</returns>
        public static float CA(float[] RN)
        {
            float temp = MathF.Log10((RN[7] + (9 * RN[6]) + (81 * RN[5]) + (729 * RN[4]) + (6561 * RN[3]) + (59049 * RN[2]) + (531441 * RN[1]) + (3587227 * RN[0])) + 1)
                / MathF.Log10(4185098 + 1);

            return temp;
        }
        /// <summary>
        /// Calculate Contact Anteriority based on provided averages
        /// </summary>
        /// <param name="R1"></param>
        /// <param name="R2"></param>
        /// <param name="R3"></param>
        /// <param name="R4"></param>
        /// <param name="R5"></param>
        /// <param name="R6"></param>
        /// <param name="R7"></param>
        /// <param name="R8"></param>
        /// <returns></returns>
        public static float CA(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R8 + (9 * R7) + (81 * R6) + (729 * R5) + (6561 * R4) + (59049 * R3) + (531441 * R2) + (3587227 * R1)) + 1)
                / MathF.Log10(4185098 + 1);

            return temp;
        }


        // Contact Posteriority
        /// <summary>
        /// Calculates Contact Posteriority based on provided average values
        /// </summary>
        /// <param name="RN">an array of averages for values in a row</param>
        /// <returns></returns>
        public static float CP(float[] RN)
        {
            float temp = MathF.Log10((RN[0] + (9 * RN[1]) + (81 * RN[2]) + (729 * RN[3]) + (6561 * RN[4]) + (59049 * RN[5]) + (531441 * RN[6]) + (4782969 * RN[7])) + 1)
                / MathF.Log10(5380840 + 1);

            return temp;
        }
        /// <summary>
        /// Calculates Contact Posteriority based on provided average values
        /// </summary>
        /// <param name="R1"></param>
        /// <param name="R2"></param>
        /// <param name="R3"></param>
        /// <param name="R4"></param>
        /// <param name="R5"></param>
        /// <param name="R6"></param>
        /// <param name="R7"></param>
        /// <param name="R8"></param>
        /// <returns></returns>
        public static float CP(float R1, float R2, float R3, float R4, float R5, float R6, float R7, float R8)
        {
            float temp = MathF.Log10((R1 + (9 * R2) + (81 * R3) + (729 * R4) + (6561 * R5) + (59049 * R6) + (531441 * R7) + (4782969 * R8)) + 1)
                / MathF.Log10(5380840 + 1);

            return temp;
        }


        // Contact Centrality
        /// <summary>
        /// Calculates Contact Centrality based on provided averages values
        /// </summary>
        /// <param name="CN">an array containing averages for values in mirroring columns</param>
        /// <returns></returns>
        public static float CC(float[] CN)
        {
            float temp = MathF.Log10(CN[0] + (17 * CN[1]) + (289 * CN[2]) + (4913 * CN[3]) + 1)
                / MathF.Log10(5220 + 1);

            return temp;
        }
        /// <summary>
        /// Calculates Contact Centrality based on provided averages values
        /// </summary>
        /// <param name="C1"></param>
        /// <param name="C2"></param>
        /// <param name="C3"></param>
        /// <param name="C4"></param>
        /// <returns></returns>
        public static float CC(float C1, float C2, float C3, float C4)
        {
            float temp = MathF.Log10(C1 + (17 * C2) + (289 * C3) + (4913 * C4) + 1)
                / MathF.Log10(5220 + 1);

            return temp;
        }



        /// <summary>
        /// Calculates row values average for an image
        /// </summary>
        /// <param name="a">a 2D array of values representing an images</param>
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

                temp = 0;
            }

            return result;
        }

        /// <summary>
        /// Calculate averages for values in columns
        /// </summary>
        /// <param name="a">a 2D array of values representing an images</param>
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

                temp = 0;
            }

            return result;
        }
    }
}
