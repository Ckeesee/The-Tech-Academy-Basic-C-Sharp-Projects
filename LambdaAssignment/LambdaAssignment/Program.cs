using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new List<(int, string, string)>
            {
                (1, "Joe", "Biden"),
                (2, "Billy", "Smith"),
                (3, "Andrew", "Clines"),
                (4, "Abigail", "Mathews"),
                (5, "Joe", "Green Horn"),
                (6, "Kelly", "Higgins"),
                (7, "Monica", "Thives"),
                (8, "Natalie", "Romanoff"),
                (9, "Kaldr", "Bricks"),
                (10, "Jethro", "Gibbs")
            };
            List<(int, string, string)> temp = new List<(int, string, string)>();
            foreach (var item in employee)
            {
                
                if (item.Item2 == "Joe")
                {
                    temp.Add((item.Item1, item.Item2, item.Item3));
                }
            }

            foreach (var item in temp)
            {
                Console.WriteLine("Emplpyee: First Name: " + item.Item2 + " Last Name: " + item.Item3 + " ID: " + item.Item1);
            }
            List<(int, string, string)> newEmp = employee.Where(x => x.Item1 >= 5).ToList();

            foreach (var item in newEmp)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3);
            }

            

        }
    }
}
