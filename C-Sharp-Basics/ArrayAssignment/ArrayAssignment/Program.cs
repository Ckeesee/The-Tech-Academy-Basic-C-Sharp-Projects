using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Jesse", "Abigale", "Todd", "Hodor", "White"};
            int[] numArray = new int[] { 5 , 123 , 18 , 9 , 13 };

            //string array indexing and print
            Console.WriteLine("Enter an index from 0-4 to see what name is in the string array:");
            int index = Convert.ToInt32(Console.ReadLine());
            bool pass = false;

            do
            {
                if (index >= 0 && index <= 4)
                {
                    Console.WriteLine("Here is your string indexed at " + index);
                    Console.WriteLine(stringArray[index]);
                    pass = true;
                }
                else
                {
                    Console.WriteLine("Please enter an index from 0-4:");
                    index = Convert.ToInt32(Console.ReadLine());
                }

            } while (!pass);

            //intger array indexing
            Console.WriteLine("Enter an index from 0-4 to see what name is in the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            bool pass2 = false;

            do
            {
                if (intIndex >= 0 && intIndex <= 4)
                {
                    Console.WriteLine("Here is your string indexed at " + intIndex);
                    Console.WriteLine(numArray[intIndex]);
                    pass2 = true;
                }
                else
                {
                    Console.WriteLine("Please enter an index from 0-4:");
                    intIndex = Convert.ToInt32(Console.ReadLine());
                }

            } while (!pass2);


            //created a list and outputing the index requested within the bounds of the list
            List<string> nameList = new List<string>();
            nameList.Add("Mark");
            nameList.Add("Bruno");
            nameList.Add("Jethro");
            nameList.Add("Odin");
            
            Console.WriteLine("Enter an index from 0-4 to see what name is in the List of strings:");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            bool pass3 = false;
            
            do
            {
                if (listIndex >= 0 && listIndex <= nameList.Count)
                {
                    Console.WriteLine("Here is your string indexed at " + listIndex);
                    Console.WriteLine(nameList[listIndex]);
                    pass3 = true;
                }
                else
                {
                    Console.WriteLine("Please enter an index from 0-" +nameList.Count + ":");
                    listIndex = Convert.ToInt32(Console.ReadLine());
                }

            } while (!pass3);

            Console.Read();

        }
    }
}
