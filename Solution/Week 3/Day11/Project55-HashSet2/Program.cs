using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    class Program
    {
        static void Main()
        {

            HashSet<string> carBrands = new HashSet<string>();


            carBrands.Add("Honda");
            carBrands.Add("Toyota");
            carBrands.Add("Ford");
            carBrands.Add("Nissan");

            carBrands.Add("Honda");
            carBrands.Add("Toyota");

            Console.WriteLine($"Number of elements in the HashSet: {carBrands.Count}");


            Console.WriteLine("\nElements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine($"\nDoes the HashSet contain 'Honda'? {carBrands.Contains("Honda")}");
            Console.WriteLine($"Does the HashSet contain 'BMW'? {carBrands.Contains("BMW")}");

            carBrands.Remove("Ford");
            Console.WriteLine($"\nAfter removing 'Ford', elements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }


            carBrands.Clear();
            Console.WriteLine("\nAfter clearing the HashSet, number of elements: " + carBrands.Count);


            List<string> moreCarBrands = new List<string>() { "Hyundai", "Kia", "Chevrolet" };
            carBrands.UnionWith(moreCarBrands);
            Console.WriteLine("\nAfter adding elements from a list, elements in the HashSet:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }


            string[] carArray = new string[carBrands.Count];
            carBrands.CopyTo(carArray);
            Console.WriteLine("\nAfter copying elements to an array, elements in the array:");
            foreach (string car in carArray)
            {
                Console.WriteLine(car);
            }

            HashSet<string> allCarBrands = new HashSet<string>() { "Honda", "Toyota", "Ford", "Nissan", "Hyundai", "Kia", "Chevrolet" };
            Console.WriteLine($"\nIs the HashSet a subset of all car brands? {carBrands.IsSubsetOf(allCarBrands)}");

            Console.WriteLine($"Is the HashSet a superset of all car brands? {carBrands.IsSupersetOf(allCarBrands)}");

            HashSet<string> anotherHashSet = new HashSet<string>() { "Nissan", "Ford", "Toyota", "Hyundai", "Chevrolet", "Kia" };
            Console.WriteLine($"Do the HashSet and another HashSet have the same elements? {carBrands.SetEquals(anotherHashSet)}");
        }
    }
}