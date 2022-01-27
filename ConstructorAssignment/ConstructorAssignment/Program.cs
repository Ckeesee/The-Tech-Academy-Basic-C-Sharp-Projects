using System;
using System.Collections.Generic;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string games = ("I love board games!");
            Console.WriteLine(games);

            var favGame = ("My favorite board game is Dungeons and Dragons!");

            Console.WriteLine(favGame);

            Console.WriteLine("What is your first name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string name2 = Console.ReadLine();

            var newPlayer = new Players(name1, name2);
            var secondPlayer = new Players("Jesse");


        }

    }
    public class Players
    {
        public Players (string fname) : this(fname, "Smith")
        {
            
        }
        public  Players (string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
            Console.WriteLine("Player {0} {1}!", firstName,lastName);

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
