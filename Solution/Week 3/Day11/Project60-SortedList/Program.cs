using System;
using System.Collections;

namespace SortedListCollectionDemo
{
    class Program
    {
        static void Main()
        {

            SortedList<string, int> carBrands = new SortedList<string, int>();


            carBrands.Add("Honda", 1);
            carBrands.Add("Toyota", 2);

            string[] moreCarBrands = { "Ford", "Chevrolet" };


            Stack<string> stackCarBrands = new Stack<string>();
            stackCarBrands.Push("BMW");
            stackCarBrands.Push("Mercedes");


            Queue<string> queueCarBrands = new Queue<string>();
            queueCarBrands.Enqueue("Nissan");
            queueCarBrands.Enqueue("Mazda");

            foreach (string brand in moreCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

            foreach (string brand in stackCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

            foreach (string brand in queueCarBrands)
            {
                carBrands.Add(brand, carBrands.Count + 1);
            }

                        Console.WriteLine("Car Brands and Their Positions:");
            Console.WriteLine($"Honda: {carBrands["Honda"]}");
            Console.WriteLine($"Toyota: {carBrands["Toyota"]}");
            Console.WriteLine($"Ford: {carBrands["Ford"]}");
            Console.WriteLine($"Chevrolet: {carBrands["Chevrolet"]}");
            Console.WriteLine($"BMW: {carBrands["BMW"]}");
            Console.WriteLine($"Mercedes: {carBrands["Mercedes"]}");
            Console.WriteLine($"Nissan: {carBrands["Nissan"]}");
            Console.WriteLine($"Mazda: {carBrands["Mazda"]}");

            var removedItem = carBrands.Remove("Honda");
            Console.WriteLine($"\nRemoved item: {removedItem}");

            for (int i = carBrands.Count - 1; i >= 0; i--)
            {
                if (carBrands.Values[i] > 4)
                {
                    carBrands.RemoveAt(i);
                }
            }

            carBrands = new SortedList<string, int>(carBrands, Comparer<string>.Default);

            carBrands.Reverse();

            Console.ReadKey();
        }
    }
}