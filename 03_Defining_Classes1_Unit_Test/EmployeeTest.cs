using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_1;

namespace _03_Defining_Classes1_Unit_Test
{
    [TestClass]
    public class EmployeeTest
    {
        //-- Field

        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            // -- Arrange
            _employee = new Employee();
            _employee.EmployeeID = 1;
            _employee.LastName = "Pascascio";
            _employee.NumberofHoursOnClock = 4000;
            _employee.Age = 27;
        }

        [TestMethod]
        public void Employee_SetLastName_IsProperString()
        {
            // -- Act

            var expected = "Pascascio";
            var actual = _employee.LastName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_EmployeeID_IsInt()
            // -- Act
        {
            var expected = 1;
            var actual = _employee.EmployeeID;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_HoursOnClock_IsCorrectInt()
        {
            // -- Act
            var expected = 4000;
            var actual = _employee.NumberofHoursOnClock;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}