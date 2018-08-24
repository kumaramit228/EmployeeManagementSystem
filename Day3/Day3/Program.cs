using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null; // ? sign makes value type nullable
            try
            {
                Console.WriteLine("Please enter marks of student or press anykey if he was absent");
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                x = null;
            }
            if (x != null)
            {
                Console.WriteLine("marks of you are {0}", x);
            }
            else Console.WriteLine("You were absent");
            Console.ReadLine();
        }
    }
}
