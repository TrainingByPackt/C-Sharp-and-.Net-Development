using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImplementSimpleIfStatement(args);
            ImplementSwitchStatement(args);
        }

        private static void ImplementSwitchStatement(string[] args)
        {
            string argCase = args[(new Random()).Next(0, 2)];
            switch (argCase)
            {
                case "firstArg":
                    Console.Write("firstArg");
                    break;
                case "SecondArg":
                    Console.WriteLine("My fav argument");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        private static void ImplementSimpleIfStatement(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There are no arguments.");
            }
            else
            {
                Console.WriteLine("There is at least one argument.");
                if (args.Length < 3)
                {
                    Console.WriteLine("Not enough arguments");
                }
            }
        }
    }
}
