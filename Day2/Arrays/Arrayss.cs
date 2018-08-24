using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrayss
    {
        static void Main(string[] args)
        {
           // SimpleArrays();
           // ArrayInitialization();
           //ImplicitArrayDeclaration();
            ArrayOfObjects();
            RectMultiDimensionalArray();
            SystemArrayFunctionality();
            Console.ReadLine();
        }
        #region simpleArrays
        static void SimpleArrays()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 77;
            myInts[2] = 2349;
            foreach (int i in myInts) Console.Write("Number in array are  {0} ", i);
            Console.WriteLine();
        }
        #endregion
        #region arrayInitialization
        static void ArrayInitialization()
        {
            string[] myString = new string[] { "Ram", "Shyam", "Rfash" };
            Console.WriteLine("No of elements in string array{0}", myString.Length);

            bool[] boolArray = { false, true, false, true};
            Console.WriteLine( "No of elements in bool array {0}",boolArray.Length);

            int[] myInts=new int[5] {55,53,5,3,553};
            Console.WriteLine( "No of elementsin int array {0}",myInts.Length);

        }
        #endregion
        #region implicit array declaration
        static void ImplicitArrayDeclaration()
        {
            var a = new[] { 1, 532, 432, 432, 24343 };
            Console.WriteLine("a is a :{0}", a.ToString());
        }
        #endregion
        #region array of objects
        static void ArrayOfObjects()
        {
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1984, 5, 1);
            myObjects[3] = "Tony Stark";

            foreach (Object obj in myObjects)
                Console.WriteLine("Type : {0}, value: {1}", obj.GetType(), obj);
        }
        #endregion

        #region multidimensional array
        static void RectMultiDimensionalArray()
        {
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i,j] = i * j;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
        #endregion

        #region jagged array
        static void JaggedArray()
        {
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 5];
            }
            for (int i = 0; i < myJagArray.Length; i++)
            {
                for(int j=0;j<myJagArray[i].Length;j++)
                {
                    Console.Write(myJagArray[i][j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region passing and recieving array
        static string[] GetStringArray()
        {
            string[] theStrings = {"apple","ball","vat"};
            return theStrings;
        }
        static void PassAndRecieveArrays()
        {
            Console.WriteLine("recieving and passing arrays");
            int[] ages = { 123, 432, 342, 34432 };
           // printArray(ages);
            String[] str = GetStringArray();
            foreach (string s in str) Console.WriteLine(s);
            Console.WriteLine();
        }
        #endregion

        #region system array functionalities
        static void SystemArrayFunctionality()
        {
            string[] gothicBands = { "tones on tail", "bauhaus", "sisters of mercy" };

            foreach (string s in gothicBands) Console.Write(s + " ,");
            Console.WriteLine();

            Array.Reverse(gothicBands);
            Console.WriteLine("The reversed array");
            foreach (string s in gothicBands) Console.Write(s + ", ");
            Console.WriteLine();
            Array.Clear(gothicBands, 1, 2);
            foreach (string s in gothicBands) Console.Write(s + ", ");
            Console.WriteLine();
        }
        #endregion
    }
}
