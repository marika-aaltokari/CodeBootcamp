using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tilaus");
            Asiakas asiakas = new()
            {
                EtuNimi = "Matti",
                SukuNimi = "Virtanen",
                Puhelin = "050-5556678",
                Sähköposti = "matvirta@gmail.com"
            };

            Tilaus tilaaja = new Tilaus();
            tilaaja.Päivämäärä = DateTime.Today;
            tilaaja.Tilaaja = "Matti Virtanen";
            tilaaja.TuoteNimi = "Ruuviavain";
            tilaaja.Kappalemäärä = "10";
            tilaaja.Hinta = "100";

            asiakas.TulostaRuudulle();
            tilaaja.TulostaRuudulleTilaus();

            //koodi OK

            Auto auto = new()
            {
                Nopeus = 0;
                MaksimiNopeus = 220_;

            };

            auto.KasvataNopeus()

           // Auto u = 
        }
    }
}
