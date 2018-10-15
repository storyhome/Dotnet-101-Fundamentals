using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependency_Injection
{
    public class ProgramUI
    {
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        internal void Run()
        {
            _console.WriteLine("Hello");
            _console.ReadKey();
        }
    }
}
