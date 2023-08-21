using System.Collections.Generic;
using System.Collections;
class Program
{
	static void Main()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(10);
		arrayList.Add("hello");
		int num1 = (int)arrayList[0]; // Explicit cast required
		string str1 = (string)arrayList[1]; // Explicit cast required
		Console.WriteLine(num1);
		Console.WriteLine(str1);

		// Example with List<T>
		List<int> list = new List<int>();
		list.Add(20);
		// list.Add("world"); // Compilation error
		int num2 = list[0]; // No explicit cast required
		Console.WriteLine(num2);
	}
}