using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseTheCheckedStatement();
            UseTheUnCheckedStatement();
        }

        private static void UseTheUnCheckedStatement()
        {
            //int y = unchecked(2147483647 + 10);
        }

        private static void UseTheCheckedStatement()
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    
                }

            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }
            
        }
    }
}
