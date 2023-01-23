using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberToCheck = 2347623;
            Console.WriteLine("The number to check: " +  numberToCheck);
            Console.WriteLine("The result: " + DigitsSummer(numberToCheck));
            Console.ReadLine();

        }

        static int DigitsSummer(int num)
        {
            if (num < 10) return num;
            return (num % 10 + DigitsSummer(num / 10));
        }
    }
}
