using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    class Tilaus
    {

        public DateTime Päivämäärä { get; set }
        public string Tilaaja { get; set}
        public string TuoteNimi { get; set}
        public int Kappalemäärä { get; set}
        public int Hinta { get; set}

        public void TulostaRuudulleTilaus()
        {
            Console.WriteLine(${ " Päivämäärä = {DateTime.today}, Tilaaja = {Tilaaja}, Tuotenimi = {TuoteNimi}, Kappalemäärä = {Kappalemäärä}, Hinta = {Hinta}"});
        }

    }



}
