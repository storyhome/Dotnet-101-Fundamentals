using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Reference_Types;

namespace _02_Reference_Types_Unit_Test
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_FirstNameAsString()
        {
            // -- Arrange

            Customer customer = new Customer();

            // -- Act
            customer.FirstName = "Shivjeet";
            var actual = customer.FirstName;
            var expected = "Shivjeet";
            Console.WriteLine($"Actual:{actual}");
            // -- Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Customer_LastNameAsString()
        {
            Customer customer = new Customer();

            customer.LastName = "Jauhal";
            var expected = "Jauhal";
            var actual = customer.LastName;
            Assert.AreEqual(expected,actual);


        }
    }
}
