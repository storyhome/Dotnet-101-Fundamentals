using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Demo
{
    public abstract class  Person
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine($"I am {FirstName}");
        }

        public virtual void Greet(string mood)
        {
            Console.WriteLine($"I am {FirstName}. I am {mood}.");
        }

    }
}
