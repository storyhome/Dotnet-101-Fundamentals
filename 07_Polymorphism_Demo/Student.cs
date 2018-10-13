using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Demo
{
    public  class Student : Person, Itrainable
    {
        public char currentGrade { get; set; }

        public override void Greet()
        {
            Console.WriteLine($"I am {FirstName}, I am a student");
        }

        public void GetTraining()
        {
            Console.WriteLine("You are getting student traing");
        }
    }
}
