using System;

namespace OlioOhjelmointi
{
    public class Tilaus
    {
        static void Main(string[] args)
        {
            public DateTime Päivämäärä {get;set }
            public string Tilaaja {get; set}
            public string TuoteNimi {get; set}
            public int Kappalemäärä {get; set}
            public int Hinta {get; set}

        public void TulostaRuudulleTilaus()
        {
            Console.WriteLine(${ " Päivämäärä = {DateTime.today}, Tilaaja = {Tilaaja}, Tuotenimi = {TuoteNimi}, Kappalemäärä = {Kappalemäärä}, Hinta = {Hinta}"});
        }


    }
    }
}