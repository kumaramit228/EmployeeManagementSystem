using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data adapters");

            string connectionString = @"Data Source =ADMIN\SQLEXPRESS;
                Integrated Security=SSPI;Initial Catalog=Recruitment";
            DataSet ds = new DataSet("Recruitment");

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Externalcandidate", connectionString);

            adapter.Fill(ds, "AmitKumar");
            //
            PrintDataSet(ds);
            Console.ReadLine();
        }
        static void PrintDataSet(DataSet ds)
        {
            foreach(DataTable dt in ds.Tables)
            {
                WriteLine($"{dt.TableName} Table");
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write(dt.Columns[curCol].ColumnName + "\t");
                }
                WriteLine("---------------------------------------");

                for(int curRow=0;curRow<dt.Rows.Count;curRow++)
                {
                    for(int curCol=0;curCol<dt.Columns.Count;curCol++)
                    {
                        Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    WriteLine();
                }
            }
            
        }
    }
}
