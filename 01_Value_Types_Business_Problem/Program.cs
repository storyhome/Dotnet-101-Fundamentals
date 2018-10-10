using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
    class Program
    {
        public enum vehicleType
        {car=1,boat,motorcycle,plane}
        static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to Komodo! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            
            Console.WriteLine("What is your vehicle Type?");
            Console.WriteLine("1 car, 2 boat, 3 motorcycle, 4 plane");
            string vehicaleChoice = Console.ReadLine();
            int choice = int.Parse(vehicaleChoice);
            vehicleType vehicleType = (Program.vehicleType) choice;
            decimal insuranceCost = 0m;

            switch(vehicleType)
            {
                case vehicleType.car:
                    if (age >18 && age <= 27) insuranceCost = 150.00m;
                    if (age > 27 && age <= 65) insuranceCost = 50.00m;
                    if (age > 65) insuranceCost = 100.00m;
                    break;
                case vehicleType.boat:
                    if (age > 18 && age <= 27) insuranceCost = 200.00m;
                    if (age > 27 && age <= 65) insuranceCost = 100.00m;
                    if (age > 65) insuranceCost = 150.00m;
                    break;
                case vehicleType.motorcycle:
                    if (age > 18 && age <= 27) insuranceCost = 240.00m;
                    if (age > 27 && age <= 65) insuranceCost = 140.00m;
                    if (age > 65) insuranceCost = 190.00m;
                    break;
                case vehicleType.plane:
                    if (age > 18 && age <= 27) insuranceCost = 210.00m;
                    if (age > 27 && age <= 65) insuranceCost = 120.00m;
                    if (age > 65) insuranceCost = 155.00m;
                    break;
            }

            Console.WriteLine($"Your cost is {insuranceCost}" );
        }
    }
}
