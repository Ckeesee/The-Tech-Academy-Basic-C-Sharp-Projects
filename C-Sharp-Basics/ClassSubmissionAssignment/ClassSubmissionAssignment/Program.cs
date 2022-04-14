using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            int favNum = 0;
            Ops math = new Ops();
            Console.WriteLine("What integer would you like to do a math operation on?");
            int num = Convert.ToInt32(Console.ReadLine());

            math.Divide(num);

            //overloaded call paramaters
            Console.WriteLine("What integer would you like to do an addition operation on?");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What decimal would you like to do a division operation on?");
            decimal num2 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("What number would you like to do and multiplication operation on?");
            string num3 = Console.ReadLine();
            //adding the int by using the sum method
            Console.WriteLine(math.Operation(num1) + " this is your number added by 32");
            //dividing the int number using the Divide method
            Console.WriteLine(math.Operation(num2) + " this is your number divided by 10");
            //multiplying the int using the mulitply method
            Console.WriteLine(math.Operation(num3) + " this is your number multiplied by 7");

            //static method calling
            Console.WriteLine("Here is 10 times 43: " + Ops.Multiply(10, 43));

            Console.WriteLine("Here is my favorite number! " + Ops.Fave(out favNum));

            Console.ReadLine();
        }
    }
            
}
