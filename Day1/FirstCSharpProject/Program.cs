using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Basic console Io****");
            //GetUserData();
            // FormatNumericalData();
            //BasicStringFunctionality();
            //stringConcat();
            //EscapeChars();
            //ImmutableTest();
            //TryStringBuilder();
            // DataTypeLimits();
            //CharTypeFunctionality();
            NewingDataTypes();
            StringInterpolation();
            Console.ReadLine();
        }
        #region Get User Data
        private static void GetUserData()
        {
            //get name and age
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age");
            string age = Console.ReadLine();

            //change console colour
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            //Echo to console
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, age);

            //restore prev color
            Console.ForegroundColor = prevColor;

        }
        #endregion
        #region Format Numerical Data
        static void FormatNumericalData()
        {
            Console.WriteLine("Value of 999999 in differenet foramts.");
            Console.WriteLine("Currency format: {0:c}", 999999);
            Console.WriteLine("d9 format: {0:d9}", 999999);
            Console.WriteLine("f3 format: {0:f3}", 999999);
            Console.WriteLine("n format: {0:n}", 999999);
            Console.WriteLine("E format: {0:E}",999999);
            Console.WriteLine("e format: {0:e}", 999999);
            Console.WriteLine("X format: {0:X}", 999999);
            Console.WriteLine("x format: {0:x}", 999999);
        }
        #endregion
        #region basic string functionality
        static void BasicStringFunctionality()
        {
            Console.WriteLine("****Basic string functions****");
            string FirstName = "Amit";
            Console.WriteLine("Value of firstname: {0}", FirstName);
            Console.WriteLine("No of characters in first name :{0}", FirstName.Length);
            Console.WriteLine("First name in upper case {0} and lower case {1}",
                FirstName.ToUpper(), FirstName.ToLower());
            Console.WriteLine("First contais T? :{0}", FirstName.Contains("T"));
            Console.WriteLine("New first name: {0}", FirstName.Replace("A", ""));
            Console.WriteLine();
        }
        #endregion
        #region string concat
        static void stringConcat()
        {
            Console.WriteLine("***string concat***");
            string s1 = "programming the ";
            string s2 = " pyschodrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        #endregion
        #region  escape chars
        static void EscapeChars()
        {
            Console.WriteLine("Escape Characters :");
            string strWitTabs = "Model\tColor\tSpeed\tPet";
            Console.WriteLine(strWitTabs);

            Console.WriteLine("Everyone loves \"Hello World\" \a");
            Console.WriteLine("C:\\myapp\\bin\\desktop\\runna");

            Console.WriteLine("All finished\n\n\n");

            Console.WriteLine(@"c:myapp\desktop\bin\debug");

            string myLongString = @"This is very

                                long string";
            Console.WriteLine(myLongString);

            Console.WriteLine(@"Stark said, ""earth is closed today""");
            Console.WriteLine("@ checking if @ can be printed");
            Console.WriteLine();
        }
        #endregion
        #region Immutable Test
        static void ImmutableTest()
        {
            string s = "my string";
            s = "This is india";
            Console.WriteLine(s);
        }
        #endregion
        #region string builder
        static void TryStringBuilder()
        {
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n");
            sb.AppendLine("half life");
            sb.AppendLine("Beyond god and evil");
            sb.AppendLine("system shock");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible war");
            Console.WriteLine(sb.ToString());
        }
        #endregion
        #region data type limits
        static void DataTypeLimits()
        {
            Console.WriteLine("** Data Type Limits  **");
            Console.WriteLine("Max of int  {0}", int.MaxValue);
            Console.WriteLine("Min of int {0}", int.MinValue);
            Console.WriteLine("Max of Double {0}", double.MaxValue);
            Console.WriteLine("Min of Double {0}", double.MinValue);
            Console.WriteLine("double.Epsilon {0}", double.Epsilon);
            Console.WriteLine("Double.+infi {0}", double.PositiveInfinity);
            Console.WriteLine("Doube.-infi {0}", double.NegativeInfinity);
            Console.WriteLine("bool.falsestring {0}", bool.FalseString);
            Console.WriteLine("bool.trueString {0}", bool.TrueString);

        }
        #endregion
        #region Char type functionalities
        static void CharTypeFunctionality()
        {
            char myChar = 'a';
            Console.WriteLine("Char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("Char.IsLetter('a): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.Iswhitespace('Hello amit',5): {0}", char.IsWhiteSpace("Hello Amit", 5));
            Console.WriteLine("char.isPuncuation('?') : {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        #endregion
        #region newing data type
        static void NewingDataTypes()
        {
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}", b, i, d, dt);
            Console.WriteLine();
        }
        #endregion
        #region string interpolation
        static void StringInterpolation()
        {
            int age = 4;
            string name = "Amit";
            string greeting = string.Format("\t hello {0} you are {1} years old",
                name.ToUpper(), age);
            Console.WriteLine(greeting);
            greeting = string.Format($"hello {name} you are {age} years old");
            Console.WriteLine(greeting);
        }
        #endregion

    }
}
