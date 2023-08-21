using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericDictionaryDemo
{
	class Program
	{
		static void Main()
		{
            List<string> myString = new();

            Dictionary<string, string> carBrands = new Dictionary<string, string>();


			carBrands.Add("Toyota", "Corolla, Camry, RAV4");
			carBrands.Add("Ford", "F-150, Mustang, Explorer");
			carBrands.Add("Honda", "Civic, Accord, CR-V");

			Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
			foreach (KeyValuePair<string, string> KVP in carBrands)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}

			Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
			for (int i = 0; i < carBrands.Count; i++)
			{
				string key = carBrands.Keys.ElementAt(i);
				string values = carBrands[key];
				Console.WriteLine($"Key: {key}, Value: {values}");
			}

			Console.WriteLine("\nAccessing Dictionary Elements using Keys");
			Console.WriteLine($"Key: Toyota, Value: {carBrands["Toyota"]}");
			Console.WriteLine($"Key: Ford, Value: {carBrands["Ford"]}");
			Console.WriteLine($"Key: Honda, Value: {carBrands["Honda"]}");

			carBrands["Toyota"] = "Corolla, Camry, Highlander, RAV4";
			Console.WriteLine("\nUpdated value of key 'Toyota': " + carBrands["Toyota"]);
			
			Console.WriteLine("\nDictionary contains 'Toyota': " + carBrands.Contains(new KeyValuePair<string, string>("Toyota", "Corolla, Camry, Highlander, RAV4")));
			Console.WriteLine("Dictionary contains key 'Ford': " + carBrands.ContainsKey("Ford"));
			Console.WriteLine("Dictionary contains value 'Explorer': " + carBrands.ContainsValue("Explorer"));

			carBrands.Remove("Honda");
			Console.WriteLine("\nDictionary after removing key-value pair for 'Honda':");
			foreach (KeyValuePair<string, string> KVP in carBrands)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}

			carBrands.Clear();
			Console.WriteLine("\nDictionary after clearing all key-value pairs:");
			Console.WriteLine("Count: " + carBrands.Count);
			
			bool added = carBrands.TryAdd("Tesla", "Model S, Model 3, Model X, Model Y");
			Console.WriteLine("\nTrying to add a new key-value pair for 'Tesla': " + added);

			string? value;
			bool retrieved = carBrands.TryGetValue("Ford", out value);
			if (retrieved)
			{
				Console.WriteLine("\nThe value for key 'Ford' is: " + value);
			}
			else
			{
				Console.WriteLine("\nThe dictionary does not contain a key for 'Ford'");
			}

			Console.ReadKey();
		}
	}
}