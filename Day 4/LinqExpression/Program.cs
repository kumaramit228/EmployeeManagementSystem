using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExpression
{
    public class ProductInfo
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string description;
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        public int NumberInStock { get; set; }

        public override string ToString()
        {
            return string.Format($"Name:{name}  Description :{description}   Number in stock: {NumberInStock}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] itemsInStock = new[]
            {new ProductInfo {Name= "Amit", Description="Cool" , NumberInStock=21},
            new ProductInfo {Name="Stark" ,Description="Ironman",NumberInStock=34},
            new ProductInfo {Name="virat", Description="Captain",NumberInStock=1 }
            };
            SelectEverything(itemsInStock);
            ListProductNames(itemsInStock);
            GetOverStock(itemsInStock);
            GetNamesAndDescription(itemsInStock);
            GetCountFromQuery();
            ReverseEverything(itemsInStock);
            AlphabetizeProductNames(itemsInStock);
            DisplayDiff();
            DisplayIntersect();
            DisplayUnion();
            DisplayConcat();
            AggregateOps();
            Console.ReadLine();
        }

        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("**All Product details**");
            var allProducts = from p in products select p; // select * from products

            foreach(var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("**Only names**");
            var names = from p in products select p.Name; //select names from 

            foreach (var n in names) Console.WriteLine("Name: {0}", n);
        }
        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The Overstock items!");
            var overStock = from p in products where p.NumberInStock > 20 select p; //where clause
            foreach (ProductInfo c in overStock)
                Console.WriteLine(c.ToString());
        }
        static void GetNamesAndDescription(ProductInfo[] products)
        {
            Console.WriteLine("Names and dscription");
            var nameDesc = from p in products select new { p.Name, p.Description };
            Console.WriteLine("Type of desc{0}", nameDesc.GetType().ToString());

            foreach(var item in nameDesc)
            {
                Console.WriteLine("Type of nameDesc{0}",item.GetType().ToString());
                Console.WriteLine(item.ToString());
            
            }
        }
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"fsda","adsfaf","sadfafaf","asdfsaff",
            "afdasfaf","kljdfkasj","uoietwqut","mcvcxzm"};
            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();

            Console.WriteLine("{0} items have more than 6 characters",( numb));
        }
        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Reversing the list");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
                Console.WriteLine(prod.ToString());
        }
        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var subset = from p in products orderby p.Name select p;

            Console.WriteLine("order by name");
            foreach(var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void DisplayDiff()
        {
            List<String> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<String> yourCars = new List<string> { "BMW", "Saab", "Azte" };

            var CarDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);
 
            Console.WriteLine();
            Console.WriteLine("****Here is what you don't have but I do***");
            foreach (string s in CarDiff) Console.WriteLine(s);
        }
        static void DisplayIntersect()
        {
            List<String> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<String> yourCars = new List<string> { "BMW", "Saab", "Azte" };

            var CarIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

            Console.WriteLine();
            Console.WriteLine("****Here is what we have in Common***");
            foreach (string s in CarIntersect) Console.WriteLine(s);
        }
        static void DisplayUnion()
        {
            List<String> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<String> yourCars = new List<string> { "BMW", "Saab", "Azte" };

            var CarUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

            Console.WriteLine();
            Console.WriteLine("****Here is what we have together***");
            foreach (string s in CarUnion) Console.WriteLine(s);
        }
        static void DisplayConcat()
        {
            List<String> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<String> yourCars = new List<string> { "BMW", "Saab", "Azte" };

            var CarConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            Console.WriteLine();
            Console.WriteLine("****Here is what we have together together***");
            foreach (string s in CarConcat) Console.WriteLine(s);
        }
        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 8.2, 0 };
            Console.WriteLine("***Mathematical Operations***");
            Console.WriteLine("Max temp {0}", (from t in winterTemps select t).Max());

            Console.WriteLine("Avg temp {0}", (from t in winterTemps select t).Average());

            Console.WriteLine("sum of temp {0}", (from t in winterTemps select t).Sum());

            Console.WriteLine("Min. of temp {0}", (from t in winterTemps select t).Min());
        }
    }
}
