using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inheritance 
    {
        static void Main(string[] args)
        {
            fun();
            B obj = new B();
            Console.ReadLine();

        }
        public static void fun()
        {
            C obj = new C();
            obj = new C();
        }
    }
}
