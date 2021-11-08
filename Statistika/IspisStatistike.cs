using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Statistika
{
    public class IspisStatistike
    {
        public static  string IspisAgenataPoZupanijama(string naziv, int broj)
        {
            string rezultat = "";
            rezultat = "U županiji " + naziv + " radi " + broj + " agenata." + Environment.NewLine;
            return rezultat;
        }

        public static string IspStrucneSpreme(string naziv, int broj)
        {
            string rezultat = "";
            rezultat += "Broj agenata sa stručnom spremom " + naziv + " iznosi: " + broj + "." + Environment.NewLine;
            return rezultat;
        }
    }
}
