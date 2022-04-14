using System;

namespace DoWhileCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a color of the rainbow!");
            string colorPicked2 = Console.ReadLine();
            
            bool isGuessed2 = colorPicked2 == "yellow";


            while (!isGuessed2)
            {
                if (colorPicked2 == "yellow")
                {
                    Console.WriteLine("You guessed green. You guessed correctly!");
                    isGuessed2 = true;
                }
                else
                {
                    Console.WriteLine("You picked wrong! Pick a color of the rainbow!");
                    colorPicked2 = Console.ReadLine();
                }
            }


            Console.WriteLine("Pick a color of the rainbow!");
            string colorPicked = Console.ReadLine();
            bool isGuessed = colorPicked == "green";
            do
            {
                switch (colorPicked)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. You guessed correctly!");
                        isGuessed = true;
                        break;
                    case "indigo":
                        Console.WriteLine("You guessed indigo. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    case "violet":
                        Console.WriteLine("You guessed violet. Try again.");
                        Console.WriteLine("Guess another color!");
                        colorPicked = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please check your spelling or pick a color within the rainbow.");
                        Console.WriteLine("Guess a color on the rainbow!");
                        colorPicked = Console.ReadLine();
                        break;



                }
            } while (!isGuessed);

            Console.Read();

        }
    }
}
