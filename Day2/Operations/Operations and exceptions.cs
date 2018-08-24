using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max size of short is {0}", short.MaxValue);
            short num1 = 30000, num2 = 30000;
            //checked   //it'll given an exception in case of overflow
             // like checked we have unchecked also
            //{
                short ans = (short)Add(num1, num2);

                Console.WriteLine("{0}+{1}+{2}", num1, num2, ans);
            //}
            NarrowingAttempt();
        }
        static int Add(int x,int y)
        {
            return x + y;
        } 
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 300;

            myByte = (byte)myInt;
            Console.Write("Value of mybyte : {0}", myByte);
            Console.ReadLine();
         }
    }
}
