using System;

namespace Ohjelmistologiikka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            const int viikonpäiviä = 7;
            int toinenLuku = 197d8;

            int luku = 987;

            Console.WriteLine(luku);

            int summa = luku + toinenLuku;

            
                
            if (luku <= 1000){
                Console.WriteLine("Luku on suurempi kuin 1000");
            } else {
                Console.WriteLine("Luku on pienempi kuin 1000");
            }

            for (int laskuri = 1; laskuri <=10; laskuri++)
            {
                Console.WriteLine(laskuri);
            }
        }
    }
}
