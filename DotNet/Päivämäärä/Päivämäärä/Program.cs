//Marikan versio
using System;

namespace Päivämäärä
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var greg = new System.Globalization.GregorianCalendar();
            var dat = new DateTime(2000, 3, 18, greg);
            Console.WriteLine($"Day of Week: {dat.DayOfWeek}");

            string s = DateTime.Now.AddDays(7).ToShortDateString();
            Console.WriteLine(s);


        }
    }
}
