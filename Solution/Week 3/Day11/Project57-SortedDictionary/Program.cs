using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new SortedDictionary with string keys and int values
        SortedDictionary<string, int> myDictionary = new SortedDictionary<string, int>();

        // Add some values to the dictionary
        myDictionary.Add("Apple", 3);
        myDictionary.Add("Cerry", 2);
        myDictionary.Add("Durian", 4);
        myDictionary.Add("Ace", 1); 

        // Add a new key-value pair to the dictionary
        myDictionary["Chocolate"] = 5;

        // Print out the contents of the dictionary
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

        Console.ReadLine();
    }
}