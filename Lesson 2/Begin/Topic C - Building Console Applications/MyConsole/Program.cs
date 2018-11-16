using System;
using static System.Console;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayOutput();
            GetInput();
        }

        private static void GetInput()
        {
            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type the page number you are on and press ENTER: ");
            string pg = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, your page number is {pg}.");
        }

        private static void DisplayOutput()
        {
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            WriteLine($"The UK population is {population}.");
            Write($"The UK population is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}.");

        }
    }
}
