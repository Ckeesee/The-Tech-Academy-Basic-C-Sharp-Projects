using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = new DateTime();
            Console.WriteLine("The current date and time is: {0}", DateTime.Now);

            Console.WriteLine("Please pick a number!");
            double userPick = Double.Parse(Console.ReadLine());

            Console.WriteLine("Here is the time with {0} hours addded to the current time: {1}", userPick, DateTime.Now.AddHours(userPick));



            Console.ReadLine();
        }
    }
}
