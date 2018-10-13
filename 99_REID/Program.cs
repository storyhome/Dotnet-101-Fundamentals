using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_REID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> _peopleList = new List<People>();
            List<Caseworker> _caseworkersList = new List<Caseworker>();
            People _people = new People();
            Caseworker _caseworker;

            _caseworker = new Caseworker
            {
                Name = "Maggie Smith",
                Company = "Fresh Start",
                Service = "Life Skills Facilitor"
            };

            _people.FirstName = "Jonathan";
            _people.LastName = "Marble";
            _people.sex = "M";
           
            _peopleList.Add(_people);
            _caseworkersList.Add((_caseworker));

            //_peopleList.AddRange(_caseworker);

        }
    }
}
