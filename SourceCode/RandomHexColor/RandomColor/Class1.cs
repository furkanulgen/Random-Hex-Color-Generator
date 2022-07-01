using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;

namespace RandomColor
{
    internal class Class1
    {
        public string HexOlustur()
        {
            Random r = new Random();
            int random0 = r.Next(1, 3);
            int random1 = r.Next(1, 3);
            int random2 = r.Next(1, 3);
            int random3 = r.Next(1, 3);
            int random4 = r.Next(1, 3);
            int random5 = r.Next(1, 3);
            string toplam = "#";

            if (random0 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            if (random1 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            if (random2 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            if (random3 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            if (random4 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            if (random5 == 1) toplam += r.Next(1, 10).ToString();
            else toplam += (char)r.Next('a', 'g');

            return toplam;
        }


        public Color ConvertToArgb(string _j)
        {
            int argb = Int32.Parse(_j.Replace("#", ""), NumberStyles.HexNumber);
            Color clr = Color.FromArgb(argb);
            return clr;
        }
    }
}
