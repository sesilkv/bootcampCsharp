using System.Diagnostics;
class Program
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();

		stopwatch.Start();

		List<object> list = new List<object>();

		for (int i = 0; i < 10000000; i++)
		{
			int num = i;
			object boxedNum = num; // boxing operation
			list.Add(boxedNum);
		}

		for (int i = 0; i < 10000000; i++)
		{
			object boxedNum = list[i];
			int unboxedNum = (int)boxedNum; // unboxing operation
		}

		stopwatch.Stop();

		Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");

	}
}

// You can define other methods, fields, classes and namespaces here