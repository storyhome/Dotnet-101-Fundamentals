using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    class Chickabee : IBird
    {
        public void MakeSound()
        {
            Console.WriteLine("Chica dee dee dee dee");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void FlapWings()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
