using System;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("What is the current day of the week?!");
                Week pick = (Week)Enum.Parse(typeof(Week), Console.ReadLine());

                Console.WriteLine(pick + " is your favorite day of the week!");

   

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid day of the week.");
                Week pick = (Week)Enum.Parse(typeof(Week), Console.ReadLine());
                
            }
            
        }
        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturaday,
            Sunday
        }
    }
}
