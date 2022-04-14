using System;

namespace optionalParamatersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2;
            int result;
            Console.WriteLine("What integer would you like to do a math operation on?");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What second number would you like to do a math operation on? (This is optional):");
            if (int.TryParse(Console.ReadLine(), out num2))
                result = Operations.math(num, num2);
            else
                result = Operations.math(num);

            //adding the int by using the sum method
            Console.WriteLine( "Your result equals: " + result);
          
            
            Console.ReadLine();
        }
    
    }
}
