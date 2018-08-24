using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadIng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Thread th = new Thread(funWithThread);
            th.Start();
            Console.WriteLine("Hello world again");
            Console.ReadLine();
                    
        }
        static void funWithThread()
        {
            Thread.Sleep(10000);
            Console.WriteLine("THis is from THread");
        }

    }

}
