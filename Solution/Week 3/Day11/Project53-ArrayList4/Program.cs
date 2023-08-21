using System.Collections;

class Program {
	static void Main(string[] args) {
		ArrayList myArrayList = new ArrayList();
		myArrayList.Add("Apple");
		myArrayList.Add("Banana");
		myArrayList.Add("Cherry");
		myArrayList.Add("Durian");

		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		myArrayList.Sort();
		
		myArrayList.Insert(2, "Elderberry");
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		Console.WriteLine("Element at index 1: " + myArrayList[1]);
		Console.WriteLine("Element at index 3: " + myArrayList[3]);


		myArrayList.Remove("Banana");
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		
		myArrayList.Clear();
		foreach(var element in myArrayList) {
			Console.WriteLine(element);
		}
		myArrayList.Add("MyFruit");
		Console.WriteLine("-------");


		bool containsDurian = myArrayList.Contains("Durian");
		Console.WriteLine("Does the ArrayList contain Durian? " + containsDurian);
		


		ArrayList myArrayListClone = (ArrayList)myArrayList.Clone();
		ArrayList myArrayListClone2 = myArrayListClone;

		string[] myArray = new string[myArrayList.Count];
		myArrayList.CopyTo(myArray);
		foreach(var element in myArray) {
			Console.WriteLine(element);
		}
		Console.WriteLine("-------");
		
		Console.WriteLine("All elements in myArrayListClone:");
		foreach (string fruit in myArrayListClone) {
			Console.WriteLine(fruit);
		}
	}
}