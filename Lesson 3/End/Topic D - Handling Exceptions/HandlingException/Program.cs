using System;
using System.IO;
using static System.Console;
namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            //CatchTheExceptionUsingCatchBlock();
            //CatchSpecificExceptions();

            //CreateTestFile();
            CreateAnotherTestFile();
        }

        private static void CreateAnotherTestFile()
        {
            using (StreamWriter writer = 
                new StreamWriter(@"C:\Code\BeginningModernCSharp\Lesson 3\AnotherTest.txt"))
            {
                writer.Write("They student is awesome.");
            }
            WriteLine("Done");
        }

        private static void CreateTestFile()
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@"C:\Code\BeginningModernCSharp\Lesson 3\test.txt");
                sw.WriteLine("Hello");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Put the more specific exception first.
                WriteLine(ex.ToString());
            }
            catch (System.IO.IOException ex)
            {
                // Put the less specific exception last.
                WriteLine(ex.ToString());
            }
            finally
            {
                sw.Close();
            }
            WriteLine("Done");
        }

        private static void CatchSpecificExceptions()
        {
            WriteLine("Before parsing");
            Write("Which page number you are in? ");
            string input = Console.ReadLine();
            try
            {
                int pg = int.Parse(input);
                WriteLine($"You are on page number {pg}.");
            }
            catch (FormatException)
            {
                WriteLine("The page number you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally {
                // Clean resource
            }

            WriteLine("After parsing");
        }

        private static void CatchTheExceptionUsingCatchBlock()
        {
            WriteLine("Before parsing");
            Write("Which page number you are in? ");
            string input = Console.ReadLine();
            try
            {
                int pg = int.Parse(input);
                WriteLine($"You are on page number {pg}.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");

            }
            WriteLine("After parsing");
        }
    }
}
