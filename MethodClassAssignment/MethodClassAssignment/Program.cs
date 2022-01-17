using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations math = new Operations();
            math.Mathmatics(8, 5);

            math.Mathmatics(multiply: 10, show: 8);

            Console.ReadLine();
        }
    }
}
