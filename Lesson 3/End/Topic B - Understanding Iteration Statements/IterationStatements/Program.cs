using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImplementWhileStatement();
            //ImplementDoWhileLoop();
            //ImplementForStatement();
            ImplementForeachStatement();
        }

        private static void ImplementForeachStatement()
        {
            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine($"{name} has {name.Length} characters.");
            }
        }

        private static void ImplementForStatement()
        {
            for (int y = 0; y < 15; y++)
            {
                Console.WriteLine(y);
            }
        }

        private static void ImplementDoWhileLoop()
        {
            string password = string.Empty;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            } while (password!="secret");
            Console.WriteLine("Correct! Good job!");
        }

        private static void ImplementWhileStatement()
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
