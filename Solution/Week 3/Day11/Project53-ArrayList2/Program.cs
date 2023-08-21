using System;
using System.Collections;

class Program {
	static void Main(string[] args) {
		ArrayList myArrayList = new();
		
		myArrayList.Add("Apple");
		myArrayList.Add("Banana");
		myArrayList.Add("Cherry");
		myArrayList.Add("Durian");
		
		Console.WriteLine("Element at index 1: " + myArrayList[1]);
		Console.WriteLine("Element at index 3: " + myArrayList[3]);

		Console.WriteLine("All elements:");
		foreach (string fruit in myArrayList) {
			Console.WriteLine(fruit);
		}
	}
}