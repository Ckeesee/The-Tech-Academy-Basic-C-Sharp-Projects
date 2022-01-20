using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee temp = new Employee() { firstName = "Sample", lastName = "Student" };
            temp.SayName();

            

            IQuittable done = new Employee();

            done.Quit();

            Console.ReadLine();
        }
    }
}
