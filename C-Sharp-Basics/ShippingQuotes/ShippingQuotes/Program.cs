using System;

namespace ShippingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("Enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimentions = height + length + width;

                int total = height * width * length * weight / 100;

                if (dimentions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\n Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
