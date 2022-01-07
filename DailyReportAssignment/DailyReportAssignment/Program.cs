using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //outputing titles
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //gathering the informaiton rquested using read and write lines
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int  yourPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool helpRequest = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? \n Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? \n Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //closing statement
            Console.WriteLine("Thank you for your answers! \nAn Instructor will respond to this shortly. \nHave a great day!");
            Console.ReadLine();
        }
    }
}
