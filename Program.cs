//Task1: Verilmiş ədəd 4 rəqəmli və 3 və ya 7 yə bölünürsə True əks halda False çap etsin
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 4-digit number:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1000 && number <= 9999 && (number % 3 == 0 || number % 7 == 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
