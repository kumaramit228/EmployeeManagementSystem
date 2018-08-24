using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Delegates
{
    class Program
    {
        delegate int Mydel(int i);
        static void Main(string[] args)
        {
            Mydel mydelegate = new Mydel(square);
            mydelegate += add;
            mydelegate += delegate (int x)
              { WriteLine("Anon called"); return x * 10; };
            mydelegate += y => y / y;
            int j = mydelegate(78);
            WriteLine(j);
            //int  a => a * 3;
            ReadLine();
        }
        static int square(int x)
        {
            WriteLine("square called");
            return x * x;
        }
        static int add(int x)
        {
            WriteLine("Add called");
            return 2 * x;
        }
    }
}
