using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee temp = new Employee() { FirstName = "Sample", LastName = "Student" };

            temp.SayName();

            Console.ReadLine();
        }
    }
}
