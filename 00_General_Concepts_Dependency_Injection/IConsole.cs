using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependency_Injection
{
   public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        string Readline();
        ConsoleKeyInfo ReadKey();
    }
}
