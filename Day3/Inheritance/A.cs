using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor of A");
        }
         ~A()
        {
            Console.WriteLine("Destructor of A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("Constructor of B");
        }
        ~B()
        {
            Console.WriteLine("Destructor of B");
        }
    }
    class C:B
    {
        public C()
        {
            Console.WriteLine("Constructor of C");
        }
        
        
        ~C()
        {
                Console.WriteLine("Destructor of C");
        }
    }
}
