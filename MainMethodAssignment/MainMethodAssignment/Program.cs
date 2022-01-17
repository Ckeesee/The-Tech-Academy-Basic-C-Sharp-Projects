using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What integer would you like to do an addition operation on?");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What decimal would you like to do a division operation on?");
            decimal num2 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("What number would you like to do and multiplication operation on?");
            string num3 = Console.ReadLine();
            //adding the int by using the sum method
            Console.WriteLine(Operations.math(num) + " this is your number added by 32");
            //dividing the int number using the Divide method
            Console.WriteLine(Operations.math(num2) + " this is your number divided by 10");
            //multiplying the int using the mulitply method
            Console.WriteLine(Operations.math(num3) + " this is your number multiplied by 7");
            

            Console.ReadLine();
        }
    }
}
