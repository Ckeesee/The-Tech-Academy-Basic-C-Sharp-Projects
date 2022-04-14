using System;
using System.Collections.Generic;
using System.Linq;

namespace SixPartLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //user input in one dimetional array
            string[] arrayString = new string[4];

            for (int i = 0; i<arrayString.Length; i++)
            {
                Console.WriteLine("Enter a name to put in the string array:");
                string name = Console.ReadLine();
                arrayString[i] = name;
            }
            //outputs names from array that user input
            Console.WriteLine("These are the names in your array:");
            for(int j = 0; j<arrayString.Length; j++)
            {
                Console.WriteLine(arrayString[j]);
            }
            

            //infinite loop fixed and looop comparison where < is used as an operator
            Console.WriteLine("These are the names in your array:");
            for(int j = 0; j<arrayString.Length; j++)
            {
                Console.WriteLine(arrayString[j]);
            }
            

            //loop comparison where <= is the operator
            Console.WriteLine("These are the names in your array:");
            for (int k = 1; k <= arrayString.Length; k++)
            {
                Console.WriteLine(arrayString[k-1]);
            }

            List<string> names = new List<string>() { "Mark", "Todd", "Harry", "Jesse" };

            Console.WriteLine("Enter a name to search for in the names bank:");
            string searchedName = Console.ReadLine();
            bool present = false;

            foreach (string name in names)
            {
                if (searchedName == name)
                {
                    Console.WriteLine(name + " is on the list!");
                    present = true;
                    break;
                }
            }

            if (present==false)
                {
                    Console.WriteLine("Sorry your name is not on the list.");
                }

            //prining out the indecies of multiple duplicate entries in a list
            List<string> names2 = new List<string>() { "Mark", "Todd", "Harry", "Jesse", "Harry", "Harry", "Todd" };

            Console.WriteLine("Enter a name to search for in the names bank:");
            string searchedName2 = Console.ReadLine();
            bool present2 = false;
            int quant = 0;

            foreach (string name in names2)
            {
                quant++;
                if (searchedName2 == name)
                {
                    Console.WriteLine(name + " is on the list at index "+ Convert.ToString(quant));
                    present2 = true;
                    
                }
            }

            if (present2 == false)
            {
                Console.WriteLine("Sorry your name is not on the list.");
            }


            //checking for which entries are duplicates and what the values are
            Console.WriteLine("Checking the List for duplicates and printing out the duplicates");
            List<string> names3 = new List<string>() { "Mark", "Todd", "Harry", "Jesse", "Harry", "Todd" };
            List<string> distinct = names3.Distinct().ToList();
            foreach (string name in distinct)
            {
                Console.WriteLine(name);
            }
                List<string> duplicates = new List<string>();
            int num = 0;
            foreach (string name in distinct)
            {
                
                num = 0;
                foreach (string check in names3)
                {
                    
                    if (name == check)
                    {
                        num++; 
                        if (num == 2)
                        {
                            duplicates.Add(name);
                            
                        }
                        
                    }
                }
            }
            foreach (string dup in duplicates)
            {
                Console.WriteLine(dup);
            }



            Console.Read();
        }
    }
}
