using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BasicAdo
{
    class Program
    {
        static void Main(string[] args)
        {
            //selectExcan();
            //insertExcan();
            deleteExcan();

            Console.ReadLine();
        }
        public static void selectExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
                connection.Open();
                string sql = "Select CCandidatecode,vfirstname from Externalcandidate";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader =myCommand.ExecuteReader())
                {
                    while(myDataReader.Read())
                    {
                        Console.WriteLine($"->Code : {myDataReader["cCandidatecode"]}," +
                            $"Name:{myDataReader["vfirstName"]}.");
                    }
                }
            }
        }
        public static void insertExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
                Console.WriteLine("Enter code followed by name");
                string code = Console.ReadLine();
                string name = Console.ReadLine();
                connection.Open();
                string sql = "Insert into Externalcandidate " + $"(cCandidatecode,vfirstname)" +
                    $"values('{code}','{name}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void updateExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
                Console.WriteLine("Enter code followed by name");
                string code = Console.ReadLine();
                string name = Console.ReadLine();
                connection.Open();
                string sql = "Insert into Externalcandidate " + $"(cCandidatecode,vfirstname)" +
                    $"values('{code}','{name}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void deleteExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
                Console.WriteLine("Enter code followed by name");
                //string code = Console.ReadLine();
                string name = Console.ReadLine();
                connection.Open();
                string sql = "delete from Externalcandidate where" + $"(vfirstname) =" +
                    $"'{name}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
