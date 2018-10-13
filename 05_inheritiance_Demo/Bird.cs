using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_inheritiance_Demo
{
    public class Bird : Animal
    {
        public override void stateType()
        {
            throw new NotImplementedException();
        }

        public override void GetMad()
        {
            Console.WriteLine("I Fly at You");
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("Im also a bird");
        }
    }
}
