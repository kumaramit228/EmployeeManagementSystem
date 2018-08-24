using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Employee
    {
        public int empId;
        public string empName;
        public int age;
        public string phone;
        public int salary;
        public string addr;
        public DateTime bday;
        public static int count=0;
        public Employee()
        {
           // Console.WriteLine("Welcome to Default constructor");
            count = count + 1;
        }
        public virtual void Accept()
        {
            Console.WriteLine("Please enter the details as asked");
            Console.WriteLine("Enter emp no");
            empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            empName = Console.ReadLine();
            Console.WriteLine("Enter address");
            addr = Console.ReadLine();
            Console.WriteLine("Enter age");
            string temp = Console.ReadLine();

            //if (int.TryParse(temp, out age)) ;
            //else Console.WriteLine("write age in corect format");
            age = int.Parse(temp);
            Console.WriteLine("Enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone no");
            phone = (Console.ReadLine());
            Console.WriteLine("Enter your Birth date in dd/mm/yy");
            bday = DateTime.Parse(Console.ReadLine());
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"name of emp {empName} and age is {age}");
           //Console.WriteLine("Details of the employee are: \n Name: {0} \n Age: {1} \n Address: {2} \n Salary: {3} \n Birth date: {4} \n", empName, age, addr, salary, bday.Date);
        }
        public static int ObjectsCount()
        {
            return count;
           // Console.WriteLine("There are {0} no of employeee", count);
        }
    }
   
}
