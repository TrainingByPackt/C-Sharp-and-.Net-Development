using System;
using static System.Console;

namespace CastingAndConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //CastIntAndDoubles();
            //ConvertToString();
            ParseToNumbersAndDates();
        }

        private static void ParseToNumbersAndDates()
        {
            //int age = int.Parse("27");
            //DateTime birthday = DateTime.Parse("4 July 1980");
            //WriteLine($"I was born {age} years ago.");
            //WriteLine($"My birthday is {birthday}.");
            //WriteLine($"My birthday is {birthday:D}.");



            Write("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }

        }

        private static void ConvertToString()
        {
            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());
        }

        private static void CastIntAndDoubles()
        {
            //// Cast an int variable into a double variable 
            //int a = 10;
            //double b = a; //an int can be stored in a double
            //WriteLine(b);

            //double c = 9.8;
            //// Cast a double variable into an int variable
            //int d = (int)c;

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");

        }
    }
}
