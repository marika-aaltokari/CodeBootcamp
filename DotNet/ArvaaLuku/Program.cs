
//ArvaaLUku-peli. Versio 1.0/30.3.2021. Tekijä: Marika Aaltokari
//Copyright (c) yritys Oy, 2021
using System;

namespace ArvaaLuku
{
    class Program
    {
        static void Main(string[] args)
        {

        const int suurinLuku = 20;
        const int arvausmäärä = 3;
        //kone arpoo luvun
            Random rand = new Random();
            int annettuLuku = rand.Next(1,suurinLuku+1);
            //Console.WriteLine("Tietokone on arponut luvun!", annettuLuku);
   
//aloitetaan käyttäjien arvausten kysyminen
            for (int kerta = 0; kerta < arvausmäärä; kerta++)
            {
                Console.WriteLine("Anna luku välillä 1-20:");
                int luku = int.Parse(Console.ReadLine());
//tarkistetaan luku
                if (luku < annettuLuku){
                    Console.WriteLine("Arvottu luku on pienempi");
                }
                else if (luku > annettuLuku){
                    Console.WriteLine("Arvottu luku on suurempi");
                } 
                else 
                {
                    Console.WriteLine("Arvottu luku on sama");
                    break;
                }
            }
            
            Console.WriteLine("Peli on päättynyt");
        }
    }
}
