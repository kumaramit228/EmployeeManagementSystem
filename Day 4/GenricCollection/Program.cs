using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricCollection
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Age > p2.Age) return 1;
            else if (p1.Age < p2.Age) return -10;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 23 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 54 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 99 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 2304 }
            };
            Console.WriteLine("Items in List: {0}",people.Count);

            foreach (Person p in people)
                Console.WriteLine(p);

            people.Insert(2, new Person { FirstName = "Amit", LastName = "Stark", Age = 2 });
            Console.WriteLine("Items in list : {0}", people.Count);

            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "AMit", LastName = "Jha", Age = 34 });
            peopleQ.Enqueue(new Person { FirstName = "skfsadj", LastName = " fjhds", Age = 39 });

            peopleQ.Dequeue();
            peopleQ.Dequeue();
          //  peopleQ.Dequeue();

            try
            {
                peopleQ.Dequeue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            Stack<Person> peopleS = new Stack<Person>();

            SortedSet<Person> sortedPerson = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName="Amit",LastName="Kumar",Age=211 },
                new Person {FirstName="AMit",LastName="KUMAr",Age=21 },
                new Person {FirstName = "amit",LastName="KUMAR",Age=212 }
            };

            foreach (Person p in sortedPerson)
                Console.WriteLine(p);

            sortedPerson.Add(new Person { FirstName = "Saadf", LastName = "stark", Age = 65 });
            sortedPerson.Add(new Person { FirstName = "sad", LastName = "target", Age = 0 });
            Console.WriteLine();
            foreach (Person p in sortedPerson)
                Console.WriteLine(p);
            Dictionary<int, Person> peopleD = new Dictionary<int, Person>();
            peopleD.Add(1, new Person { FirstName = "Amit", LastName = "jha", Age = 22 });
            peopleD.Add(2, new Person { FirstName = "virat", LastName = "Kohli", Age = 29 });
            peopleD.Add(3, new Person { FirstName = "I am", LastName = "stark", Age = 45 });
            Console.WriteLine("Dictionary result");
            Person x = peopleD[1];
            Console.WriteLine(x);
           
            Dictionary<int, Person> peopleB = new Dictionary<int, Person>()
            {
                { 1, new Person { FirstName = "Amit", LastName = "jha", Age = 22 }},
                { 2, new Person { FirstName = "virat", LastName = "Kohli", Age = 29 } }
            };
            Console.WriteLine();
            Person y = peopleD[1];
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
