using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class ContractEmployee:Employee
    {
        string ContrEmpid;
        public ContractEmployee():base()
        {
            Console.WriteLine("Constructor of directEmployee");
        }
        public override void Accept()
        {
            Console.WriteLine("Enter direct employee Id");
            ContrEmpid = Console.ReadLine();
            base.Accept();
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Direct Employee id is: {ContrEmpid}");
            base.DisplayDetails();
        }
    }
}
