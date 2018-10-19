using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            BadgeRepository _badgeRepository = new BadgeRepository();

            Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                 " 1. Add a badge\n 2. Edit a badge\n 3. List all badges");

            var menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        Badge badge = new Badge();
                        Console.WriteLine("What is the number on the badge?");
                        badge.BadgeId = int.Parse(Console.ReadLine());
                        var add_door = true;
                        Console.WriteLine("List a door that it needs access to:");
                        badge.DoorName.Add(Console.ReadLine());

                        while (add_door)
                        {
                            Console.WriteLine("Any other doors (y/n)?");
                            if ((Console.ReadLine().ToUpper() == "Y"))
                            {
                                Console.WriteLine("List a door that it needs access to:");
                                badge.DoorName.Add(Console.ReadLine());
                            }
                            else
                                add_door = false;
                        }

                        _badgeRepository.AddBadge(badge);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("What is the badge number to update?");


                        break;
                    }
            }



            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Employee Age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary: ");
            var salary = double.Parse(Console.ReadLine());

        }


    }
}
