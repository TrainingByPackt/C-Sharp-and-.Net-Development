using System;

namespace MyLibrary
{
    public class Car
    {
        public readonly int Year;
        public Car(int year)
        {
            Year = year;
        }

        public string CarName { get; set; }

        public static void WriteSomething() {
            Console.WriteLine("Something!");
        }
    }

    static public class CarV2
    {
        static public readonly int Year;
        static public string CarName { get; set; }
    }
}
