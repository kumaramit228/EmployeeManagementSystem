using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EMS
    {

        static string empName = "", addr = "";
        static int age = -1, salary = 0;
        static string phone = "";
        static DateTime bday = DateTime.Today;
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine(" Select your choice: 1 [Enter details]   2 [View details]");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EnterDetails();
                        break;
                    case 2:
                        DisplayDetails();
                        break;
                }
            } while (choice == 1 || choice == 2);
            Console.Write("Exiting now");
            Console.Read();
        }
        static void EnterDetails()
        {
            Console.WriteLine("Please enter the details as asked");
            Console.WriteLine("Enter name");
            empName = Console.ReadLine();
            Console.WriteLine("Enter address");
            addr = Console.ReadLine();
            Console.WriteLine("Enter age");
            string temp = Console.ReadLine();

            if (int.TryParse(temp, out age)) ;
            else Console.WriteLine("write age in corect format");
            //age = int.Parse();
            Console.WriteLine("Enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone no");
            phone = (Console.ReadLine());
            Console.WriteLine("Enter your Birth date in dd/mm/yy");
            bday = DateTime.Parse(Console.ReadLine());
        }
        static void DisplayDetails()
        {
            if (age == -1) Console.WriteLine("No details found,please enter details by selecting appropriate options");
            else
            {
                Console.WriteLine("Details of the employee are: \n Name: {0} \n Age: {1} \n Address: {2} \n Salary: {3} \n Birth date: {4} \n", empName, age, addr, salary,bday.Date);
            }
        }
        
    }
}
