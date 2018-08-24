using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum EmpType : byte
    {
        Manager = 10,
        Grunt =1,
        Contractor=100,
        VicePresident=9,
    };
    class Program
    {
        static void Main(string[] args)
        {
            EmpType e2 = EmpType.Contractor;
            Console.WriteLine(e2.ToString());
            byte a = (byte)e2;
            Console.WriteLine(a);
            AskForBonus(e2);
            Console.ReadLine();
        }
        #region code for bonus
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("Get some stocks for him");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("Are you kidding me!");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already have infi cash");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("I'll look into it");
                    break;
            }
        }
        #endregion
    }
}
