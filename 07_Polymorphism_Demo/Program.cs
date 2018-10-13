using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people =  new List<Person>();

           Student student = new Student();
            student.FirstName = "Kenn";
            student.currentGrade = 'A';
            student.Greet();
            student.Greet("happy");
            student.GetTraining();

            Instructor instructor = new Instructor();
            ;
            instructor.FirstName = "Lawrence";
            instructor.Greet();
            instructor.LastName = "Wagner";
            instructor.Greet();
            instructor.GetTraining();
            ;







            Person person = new Student();
            person.FirstName = "Ben";

            people.Add(student);
            people.Add(person);

            foreach (var p in people)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
            }
        }
    }
}
