using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
    public class Ops
    {
        //void method
        public void Divide(int num1)
        {
            int total = num1 / 2;
            Console.WriteLine("Here is your number divided by 2: " + total);
        }

        //static class
        public static int Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }

        public static int Fave(out int favNum)
        {
            favNum = 21;
            favNum += 100;
            return favNum;

        }
    

    //overloaded methods
        public  int Operation(decimal num)
            {
                int total = Convert.ToInt32(num) / 10;
                return total;
            }

        public  int Operation(string num)
        {
            int total = Convert.ToInt32(num) * 7;
            return total;
        }

        public  int Operation(int num)
        {
            int total = num + 32;
            return total;
        }


    }
}
