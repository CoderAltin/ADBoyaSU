using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBoyaSU
{
    public static class SonuclarFiles
    {
        // Ü İ Ö Ğ I Ə Ç Ş
        // ü i ö ğ ı ə ç ş
        static string sonucText = "\tAd      |     CA     |     CP     |     CC     |\n" +
                            "----------------+------------+------------+------------+\n";
        static string rowSeparator = "----------------+------------+------------+------------+\n";

        static string proTip = "\n\n\n" +

            "Yaxçi Bax 0: Yaxçı Bax 4'ə Yaxçı Bax\n" +

            "Yaxçı Bax 1: 'Ad' sutunundakı adların hammısı bir-birinə bənzəməsə," +
            "(tutak 'ceyran_1.png, taymaz_1.png, solmaz_1.png', ama birdən 'ayran_3.png, zaparat_3.png')" +
            "əkıslərin 3-dənə 3-dənə döül dimək olar.\n" +

            "Yaxçı Bax 2: Yaxçı Bax.\n" +

            "Yaxçı Bax 3: Bırada birzad yox. ama sən gənə Yaxçı Bax 1'ə Yaxçı Bax\n" +

            "Yaxçı Bax 4: Yaxçı Bax 3'ə Yaxçı Bax\n\n" +
            
            
            " -- + -------------------- + -- \n\n" +


            "Pro Tip 0: Pay Attention to Pro Tip 4.\n" +

            "Pro Tip 1: If the names in the 'Ad' column do not look alike," +
            "(say, they're all like 'ceyran_1.png, taymaz_1.png, solmaz_1.png', but suddenly 'ayran_3.png, zaparat_3.png')" +
            "there's a good chance your images are not triple-triple, something's wrong with them.\n" +

            "Pro Tip 2: Pay Attention.\n" +

            "Pro Tip 3: There's nothing here. But you still Pay Attention to Pro Tip 1 anyways.\n" +
            
            "Pro Tip 4: Pay Attention to Pro Tip 3.\n";



        public static string GetSonucText()
        {
            sonucText += "\n\n\n\n" +
                "\t +------------------------------------+\r\n" +
                "\t |    ADBoyaSU. Ərşan - Altin 2024    |\r\n" +
                "\t +------------------------------------+\r\n";

            sonucText += proTip;


            return sonucText;
        }

        public static void AddThisToSonucText(string name, float CA, float CC, float CP)
        {
            sonucText += CheckLength(name, 16) + "| " + CheckLength(CA, 11) + "| " + CheckLength(CC, 11) + "| " + CheckLength(CP, 11) + "| \n";
            sonucText += rowSeparator;
        }


        static string CheckLength(float f, int length)
        {
            string s = f.ToString();

            if (s.Length < length)
            {
                int d = length - s.Length;
                for (int i = 0; i < d; i++)
                    s += " ";
            }
            else if (s.Length > length)
                s = s.Substring(0, length);

            return s;
        }
        static string CheckLength(string s, int length)
        {
            if (s.Length < length)
                s += "\t";
            else if (s.Length > length)
                s = s.Substring(0, length);

            return s;
        }
    }
}
