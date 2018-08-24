using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Loops and choices***");
            //ForAndForEachLoop();
            //VarInForEachLoop();
            //ExecuteWhileLoop();
            //ExecuteDoWhileLoop();
            //ExecuteIfElse();
            //ExecuteSwitch();
            //ExecuteSwitchOnStrings();
            //SwitchOnEnumExample();
            //UseDateAndTimes();
            Console.ReadLine();
        }
        #region For and For each loops
        static void ForAndForEachLoop()
        {
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("Number is {0}", i);
            }
            string[] carTypes = { "BMW", "Ford", "Mercedes", "Audi" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
            int[] myInts = { 10, 45, 786, 873482 };
            foreach (int i in myInts) Console.WriteLine(i);
        }
        #endregion
        #region var in for each loop
        static void VarInForEachLoop()
        {
            int[] myInts = { 10, 45, 786, 873482 };
            foreach (var item in myInts) Console.WriteLine("Item value {0}", item);
        }
        #endregion
        #region while Loop
        static void ExecuteWhileLoop()
        {
            string userIsDone = "";
            while(userIsDone.ToLower() != "yes")
            {
                Console.Write("Are you done? [yes] [no]:");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
            Console.WriteLine();
        }
        #endregion
        #region do while loop
        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while Loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
            Console.WriteLine();
        }
        #endregion
        #region if/else
        static void ExecuteIfElse()
        {
            string stringData = "My textual data";
            if(stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            Console.WriteLine();
        }
        #endregion
        #region switch statements
        static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2[VB]");
            Console.Write("Please pick your language prefernce: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch(n)
            {
                case 1:
                    Console.WriteLine("Good choice, c# is a fine language");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading and more");
                    break;
                default:
                    Console.WriteLine("well....good luck with that");
                    break;
            }
            Console.WriteLine();
        }

        #endregion
        #region execute switch on strings
        static void ExecuteSwitchOnStrings()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language");
            string langChoice = Console.ReadLine();
            switch(langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a good language");
                    break;
                case "VB":
                    Console.WriteLine("VB, OOP, multithreading and more");
                    break;
                default:
                    Console.WriteLine("Good luck with that");
                    break;
            }
            Console.WriteLine();
        }
        #endregion
        #region switch on enum
        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your fav. day of week");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("bad Input!");
                return;
            }

            switch(favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday rules");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("work hard");
                    break;
                //default:
                //    Console.WriteLine("another day, another dollar");
                //    break;
            }
        }
        #endregion
        #region date and time 
        static void UseDateAndTimes()
        {
            Console.WriteLine("Date and Time");
            DateTime dt = new DateTime(2015, 10, 17);
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();

        }
        #endregion
    }
}
