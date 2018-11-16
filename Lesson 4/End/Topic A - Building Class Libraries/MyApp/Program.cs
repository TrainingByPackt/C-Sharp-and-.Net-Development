using MyLibrary;
using System;

namespace MyApp
{
    class Program
    {
        const string productType = "Fancy Cars";
        private static void Main(string[] args)
        {
            //DemoCar();
            DemoOptionalParameters("Jump", 98.5);
        }

        private static void DemoCar()
        {
            Car greenCar = new Car(2121);
            greenCar.CarName = "SuperCool";
            Console.WriteLine($"My car is called: " + greenCar.CarName +
                                "; The car year is " + greenCar.Year);

            Car.WriteSomething();
            //CarV2.CarName = "SuperCool";
            //Console.WriteLine($"My car is called: " + CarV2.CarName);
        }

        static public void DemoOptionalParameters(string command = "Run!",
                               double number = 0.0,
                               bool active = true)
        {
            Console.WriteLine($"command is {command}, number is {number}, active is { active}");
        }

    }
}
