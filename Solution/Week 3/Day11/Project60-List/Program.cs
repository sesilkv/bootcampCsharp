using System;
using System.Collections.Generic;

namespace GenericListCollectionDemo
{
    class Program
    {
        static void Main()
        {

            List<string> carBrands = new List<string>();


            carBrands.Add("Honda");
            carBrands.Add("Toyota");

            string[] moreCarBrands = { "Ford", "Chevrolet" };


            Stack<string> stackCarBrands = new Stack<string>();
            stackCarBrands.Push("BMW");
            stackCarBrands.Push("Mercedes");


            Queue<string> queueCarBrands = new Queue<string>();
            queueCarBrands.Enqueue("Nissan");
            queueCarBrands.Enqueue("Mazda");

            
            carBrands.AddRange(moreCarBrands);
            carBrands.AddRange(stackCarBrands);
            carBrands.AddRange(queueCarBrands);


            carBrands.Insert(2, "Audi");


            var isPresent = carBrands.Contains("Toyota");
            Console.WriteLine($"Is Toyota present in the list? {isPresent}");


            var removedItem = carBrands.Remove("Honda");
            Console.WriteLine($"\nRemoved item: {removedItem}");


            var removedAll = carBrands.RemoveAll(c => c.StartsWith("M"));
            Console.WriteLine($"\nNumber of items removed: {removedAll}");

            string[] carBrandsArray = new string[carBrands.Count];
            carBrands.CopyTo(carBrandsArray);

            var firstMatch = carBrands.Find(c => c.StartsWith("F"));
            Console.WriteLine($"\nFirst match: {firstMatch}");

            var allMatches = carBrands.FindAll(c => c.StartsWith("B"));
            Console.WriteLine("\nAll matches:");
            foreach (var match in allMatches)
            {
                Console.WriteLine(match);
            }

            var lastMatch = carBrands.FindLast(c => c.StartsWith("N"));
            Console.WriteLine($"\nLast match: {lastMatch}");


            carBrands.Sort();

        
            carBrands.Reverse();


            Console.WriteLine("\nCar Brands:");
            foreach (var carBrand in carBrands)
            {
                Console.WriteLine(carBrand);
            }

            Console.ReadKey();
        }
    }
}