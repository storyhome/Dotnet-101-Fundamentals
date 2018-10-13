using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    public enum MovementType { Walk = 1, Fly, Swim }
    public class Bird
    {

        public Bird() { }
        public Bird(string name, bool talons, MovementType move, int eggs)
        {
            Name = name;
            HasTalons = talons;
            MovementType = move;
            NumberOfEggs = eggs;
        }
        public string Name { get; set; }
        public bool HasTalons { get; set; }
        public MovementType MovementType { get; set; }
        public int NumberOfEggs { get; set; }
    }
}
