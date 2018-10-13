using System;
using _04_Encapulation2_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapsulation_1_Unit_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Customer _customer;
            //_customer1 = new Customer("John", "Smith","34","Repeat Problem Connecting");
            //_customer1 = new Customer("John", "Smith", "34", "Repeat Problem Connecting");
            //_customer1 = new Customer("John", "Smith", "34", "Repeat Problem Connecting");

        }
        



        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer();
            customer.FirstName = "Kenn";
            customer.LastName = "Pascascio";
            Console.WriteLine(customer.FirstName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "This is out of range")]
        public void Customer_Age_ExceptionoNRange()
        {
            var customer = new Customer("Tony","Reid",0,"What day");
           
         }

        //TDDO: Cleanup the exceptions, Currently Failing

        [TestMethod]
        [ExpectedException(typeof(Exception), "First name cannot be empty")]
        public void Customer_FirstName_ExceptionoNValue()
        {
            var customer = new Customer("", "Reid", 0, "What day");

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "last name cannot be empty")]
        public void Customer_LastName_ExceptionoNValue()
        {
            var customer = new Customer("Tony", "", 0, "What day");

        }

        
    }
}
