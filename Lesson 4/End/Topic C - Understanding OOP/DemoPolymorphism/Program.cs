using System;
using System.Collections.Generic;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 4
            const int hours = 50, wage = 70;
            List<Employee> employees = GetEmployees();
            foreach (var e in employees)
            {
                e.DetermineWeeklySalary(hours, wage);
            }
        }

        // Step 3
        private static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }
    }
    // Step 1
    public class Employee
    {
        public virtual void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine($"\nThis EMPLOYEE worked {weeklyHours} hrs. " +
                                $"Paid for 40 hrs (no overtime) at $ {wage}" +
                                $"/hr = ${salary} \n");
            Console.WriteLine("---------------------------------------------\n");
        }
    }

    // Step 2
    public class Contractor : Employee
    {
        public override void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine($"\nThis CONTRACTOR worked {weeklyHours} hrs. " +
                              $"Paid for {weeklyHours} hrs (w/ overtime) at $ {wage}" +
                              $"/hr = ${salary} ");
        }
    }
    
}
