using System;

namespace KysyNimi
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name;

            Console.WriteLine("Mikä on nimesi?");

            name = Console.ReadLine();

            //Console.WriteLine("Tervetuloa, {0}",name);
            Console.WriteLine("Hei " + name + " !");
        }
    }
}
