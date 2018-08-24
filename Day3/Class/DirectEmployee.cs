using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class DirectEmployee:Employee
    {
        string DEmpid;
        public DirectEmployee():base()
        {
            Console.WriteLine("Constructor of directEmployee");
        }
        public override void Accept()
        {
            Console.WriteLine("Enter direct employee Id");
            DEmpid = Console.ReadLine();
            base.Accept();
        }
        public override void  DisplayDetails()
        {
            Console.WriteLine($"Direct Employee id is: {DEmpid}");
            base.DisplayDetails();
        }
    }
}
