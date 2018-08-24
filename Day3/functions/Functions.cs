using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Functions
    {
        static void Main(string[] args)
        {
            int x = 9, y = 10;
            swapnorm(x, y);
            Console.WriteLine("Values after norm swap x: {0}  y:{1}", x, y);
            swap(ref x, ref y);

            Console.WriteLine("Values after call swap x {0} y: {1}", x, y);

            int addi;
            int multi;
            add(out addi,out multi,10,20);
            Console.WriteLine("Learning out function add {0} and multi {1}", addi, multi);
            Console.ReadLine();
        }
        static void swapnorm(int x, int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;
        }
        static void swap(ref int x, ref int y)
        {
            y = x + y;
            x = y - x;
           // Cons
            y = y - x;
        }
        static void add( out int ans,out int multi, int a = 65, int b = 98)
        {
            ans = a + b;
            multi = a * b;
        }
    }
}
