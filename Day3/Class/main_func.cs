using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class main_func
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            //e = new DirectEmployee();
            e.Accept();
            InsertEmp(e);
            //e.DisplayDetails();
            Console.ReadLine();
        }
        public static void InsertEmp(Employee e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
                connection.Open();
                string sql = "Insert into EMPDETAIL (EMPID,EMPNAME,ADDRESS,AGE,BDAY,SALARY,PHONE)" + 
                  " VALUES "+ $"({e.empId},'{e.empName}','{e.addr}',{e.age},'{e.bday}',{e.salary},'{e.phone}')";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
       
            //Employee[] emp=new Employee[10];
            //int choice;
            //do
            //{
            //    Console.WriteLine(" Select your choice: 1 [Enter details]   2 [View details]");
            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            if (Employee.ObjectsCount() < 10)
            //            {
            //                emp[Employee.ObjectsCount()] = new Employee();
            //                emp[Employee.ObjectsCount()-1].Accept();
            //            }  
            //            else
            //                Console.WriteLine("Memory limit reached");
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter employee no for which you want to see details");
            //            int x = int.Parse(Console.ReadLine());
            //            if (x <= Employee.ObjectsCount())
            //                emp[x - 1].DisplayDetails();
            //            else Console.WriteLine("Employee doesn't exist");
            //            break;
            //    }
            //} while (choice == 1 || choice == 2);
            //Console.Write("Exiting now");
    }
}
