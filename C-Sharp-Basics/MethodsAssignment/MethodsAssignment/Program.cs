using System;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do math operations on?");
            int num = Convert.ToInt32(Console.ReadLine());

            //dividing the int number using the Divide method
            Console.WriteLine(Operations.Divide(num) + " this is your number divided by 10");
            //multiplying the int using the mulitply method
            Console.WriteLine(Operations.Multiply(num) + " this is your number multiplied by 7");
            //adding the int by using the sum method
            Console.WriteLine(Operations.Sum(num) + " this is your number added by 32");

            Console.ReadLine();
        }

    }
}
