using System;

namespace Summa
{
    class Program
    {
        public static int Sum(int num1, int num2){

            int summa;
            summa = num1 + num2;
            return summa;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Anna kokonaisluku1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            //ope:int luku2 = int.Parse(luku1); string luku1
            Console.WriteLine("Summa on: {0} ", Sum(n1,n2));

        
        }
    }
}
