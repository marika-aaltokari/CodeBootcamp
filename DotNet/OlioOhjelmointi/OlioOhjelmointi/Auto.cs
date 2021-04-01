using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    class Auto
    {
        
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public string Väri { get; set; }
        public int Vuosi { get; set; }

        public int Nopeus { get; private set; }
        public int Maximinopeus { get;  private set; }
       
        //konstruktori
        public Auto(int maksiminopeus)
        {
            Maksiminopeus = maksiminopeus;
        }

        public void KasvataNopeus()
        {
            if (Huippunopeus >0) && (Nopeus <  Huippunopeus )
            {
                Nopeus += 10;
                Console.WriteLine($ { "Nopeus = { Nopeus}"});
            }
            else {
                Nopeus = Maximinopeus;
                Console.WriteLine(Nopeus);

            }

            
        }
        public void VähennäNopeus()
        {
           while (Nopeus > 0)
            {
                Nopeus -= 10;
                Console.WriteLine($ { "Nopeus = { Nopeus}"});
            }
            Nopeus = 0;
        }
    }
}
