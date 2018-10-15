using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI(new GoodConsole());
            program.Run();
        }
    }

   
}
