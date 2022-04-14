using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval:");
            Console.WriteLine("What is your age?");
            string ageinput = Console.ReadLine();
            int age = Convert.ToInt32(ageinput);

            Console.WriteLine("Have you ever had a DUI? (Yes/No)");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketInput = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketInput);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && DUI == "No" && tickets <= 3);

            Console.ReadLine();
        }
    }
}
