using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassAssign
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("This job isn't working for me!");
        }
        public static bool operator==(Employee employee,Employee employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operator!=(Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
                return false;
            else
                return true;
        }
    }
}
