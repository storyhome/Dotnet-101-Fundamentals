using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Repository
{
    public class Employee
    {
        public int EmployeeID { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}
