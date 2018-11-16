using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExploringNumbers();
            //AssignLocalVariables();
            StoreMultipleValuesInAnArray();
        }

        private static void StoreMultipleValuesInAnArray()
        {
            // declare the size of the array
            string[] names = new string[4];

            // store items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]); // read the item at this index
            }


        }

        private static void AssignLocalVariables()
        {
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false
            
        }

        private static void ExploringNumbers()
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range:\n\n" +
                $"{ int.MinValue:N0} to { int.MaxValue:N0}.\n");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range:\n\n" +
                $"{ double.MinValue:N0} \n\n  to \n\n { double.MaxValue:N0}.\n");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range:\n\n " +
                $"{ decimal.MinValue:N0} \n\n to \n\n { decimal.MaxValue:N0}.\n");


        }
    }
}
