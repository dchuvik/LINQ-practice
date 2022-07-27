using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ages = new List<int>() { 2, 13, 4, 45, 56, 1, 7, 11, 9, 10 };
            Console.WriteLine();

            //Where();
            Console.WriteLine("Where:");
            ages.Where(x => x > 5).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //Select();


            //Sort();
            Console.WriteLine("Sort");
            ages.Sort();
            ages.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //Sum();
            Console.WriteLine(ages.Sum());
            Console.WriteLine();

            //Average();
            Console.WriteLine($"Average: {ages.Average()}");

            //Count();
            Console.WriteLine($"Count: {ages.Count()}");

            //Min();
            Console.WriteLine($"Min: {ages.Min()}");

            //Max();
            Console.WriteLine($"Max: {ages.Max()}");
            Console.WriteLine();

            //Take();
            Console.WriteLine("Take (2)");
            var newList = ages.Take(2);
            foreach (var age in newList)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine();

            //Append();
            ages.Append(8).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();


            //ThenBy();
            string[] fruits = { "grape", "passionfruit", "banana", "mango",
                      "orange", "raspberry", "apple", "blueberry" };
            var query = fruits.OrderBy(fruit => fruit.Length).ThenBy(fruit => fruit);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
