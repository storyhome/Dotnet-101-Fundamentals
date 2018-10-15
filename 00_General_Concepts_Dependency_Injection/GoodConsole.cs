using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependency_Injection
{
    public class GoodConsole : IConsole
    {
        public void WriteLine(string s)
        {
            Console.WriteLine("This is Good Console");
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
           Console.WriteLine(o);
        }

        public void Write(string s)
            
        {
            Console.Write(s);
        }

        public string Readline()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
