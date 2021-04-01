using System;

namespace OlioOhjelmointi
{
    public class Tilaus
    {
        static void Main(string[] args)
        {
            public DateTime P‰iv‰m‰‰r‰ {get;set }
            public string Tilaaja {get; set}
            public string TuoteNimi {get; set}
            public int Kappalem‰‰r‰ {get; set}
            public int Hinta {get; set}

        public void TulostaRuudulleTilaus()
        {
            Console.WriteLine(${ " P‰iv‰m‰‰r‰ = {DateTime.today}, Tilaaja = {Tilaaja}, Tuotenimi = {TuoteNimi}, Kappalem‰‰r‰ = {Kappalem‰‰r‰}, Hinta = {Hinta}"});
        }


    }
    }
}