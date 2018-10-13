using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapulation2_1
{
    public class Customer
    {
        //public string FirstName {get; set;}
        private string _firstName;

        public Customer()
        {
        }

        public Customer(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public Customer(string name, string lastName, int age, string question)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Question = question;
        }

        

        public string FirstName
        {
            get => _firstName;
            
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("First name cannot be empty");
                else
                    _firstName = value.Trim();

            }
        }

        
        private string _lastName;

        public string LastName
        {
            get => _lastName;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("last name cannot be empty");
                else
                    _lastName = value.Trim();
            }
        }

        private int _age;

        public int Age
        {
            get =>_age;

            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("This is out of range");
                else
                _age = value;
            }
        }


       
        public string Question { get; set; }

        


    }
}
