using System;
using static System.Console;
namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Age = 46, FirstName = "Jay", LastName = "Sky" };
            WriteLine($"His " + nameof(p1.FirstName) + " is " + p1.FirstName);
            p1.DoSomething();

            Student s1 = new Student();
            //Female f1 = new Female();
        }
    }

    class Student : Female
    {
        public int StudentID { get; set; }

    }

    abstract class Female : Person {
        void DoAnything()
        {
            Console.WriteLine("Doing antyhing");
        }
    }

    class Person : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void DoSomething()
        {
            WriteLine("No trees were hurt during the development of this program.");
        }
    }

    interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        void DoSomething();
    }
}
