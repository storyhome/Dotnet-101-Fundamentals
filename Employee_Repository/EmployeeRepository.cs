using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Repository
{
    public class EmployeeRepository
    {
         List<Employee> _employees =  new List<Employee>();
        Queue<int> queue    = new Queue<int>();

        public void AddEmployeeToList(Employee model)
        {
            _employees.Add(model);

       
        }

        public List<Employee> GetList()
        {
            return _employees;
        }

        public void RemoveEmployeeByName(string name)
        {
            foreach (Employee e in _employees)
            {
                if (e.Name == name)
                {
                    _employees.Remove(e);
                    break;
                }
            }

            
        }
    }
}
