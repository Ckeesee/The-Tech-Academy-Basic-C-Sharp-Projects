using System;
using System.Collections.Generic;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> nums = new List<int>() { 8,15,183,98,563,5,2};
            try
            {
                Console.WriteLine("Enter a number to divide the list of numbers by:");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int num in nums)
                {
                    Console.WriteLine(num + " divided by " + userNum + " equals:");
                    Console.WriteLine(num / userNum);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Made it through with with or without errors or excpetions!");
            Console.ReadLine();
        }
    }
}
