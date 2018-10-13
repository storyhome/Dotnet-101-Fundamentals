using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Demo
{
    class Instructor : Person, Itrainable
    {
        public override void Greet()
        {
            Console.WriteLine($"Hello. I am an instructor. My name is Mr. {LastName}");
        }

        public void GetTraining()
        {
            Console.WriteLine("YOu are training numerous students today");
        }
    }
}
