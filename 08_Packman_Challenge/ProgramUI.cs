using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Packman_Challenge
{
    public class ProgramUI
    {
        private PackManRepository packManRepo = new PackManRepository();

        public void Run()
        {
            packManRepo.GetInput(@"C:\Users\tonyr\source\repos\Dotnet 101-Fundamentals\08_Packman_Challenge\data.csv");
            packManRepo.PlayGame();
        }
        
    }
}
