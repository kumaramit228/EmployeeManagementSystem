using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
       
        static void Main(string[] args)
        {
            System.IO.StreamReader str = null;
            try
            {
                str = new System.IO.StreamReader(@"C:\Amit\Citi\c#\exceptiom.txt");
                Console.WriteLine(str.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Something went wrong{0}", ex.FileName);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("directory not found :{0}", ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally block");
                if(str != null)
                {
                    str.Close();
                }
            }
            Console.WriteLine("Out of finally block");
            Console.ReadLine();
        }
    }
}
