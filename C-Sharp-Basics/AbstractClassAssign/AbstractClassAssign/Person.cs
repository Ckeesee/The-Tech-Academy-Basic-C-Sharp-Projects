using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssign
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Here is your name: " + firstName + " " + lastName);
        }

    }
}
