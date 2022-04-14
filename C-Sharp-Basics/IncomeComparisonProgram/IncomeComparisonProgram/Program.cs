using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");



            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate1 = Console.ReadLine();
            decimal rate1 = Convert.ToDecimal(hourlyRate1);
            Console.WriteLine("Hours worked per week:");
            string hoursWorked1 = Console.ReadLine();
            decimal hours1 = Convert.ToDecimal(hoursWorked1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate2 = Console.ReadLine();
            decimal rate2 = Convert.ToDecimal(hourlyRate2);
            Console.WriteLine("Hours worked per week:");
            string hoursWorked2 = Console.ReadLine();
            decimal hours2 = Convert.ToDecimal(hoursWorked2);

            decimal annual1 = rate1 * hours1 * 52;
            decimal annual2 = rate2 * hours2 * 52;

            Console.WriteLine("Annual Salary of Person 1: $" + annual1);

            Console.WriteLine("Annual Salary of Person 2: $" + annual2);

            bool comparison = annual1 > annual2;

            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + comparison);

            Console.ReadLine();

        }
    }
}
