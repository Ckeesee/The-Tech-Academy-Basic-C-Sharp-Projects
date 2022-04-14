using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstApp
{
     class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Mark" };

                
                db.Students.Add(stud);
                db.SaveChanges();
            }
        }
    }


}
