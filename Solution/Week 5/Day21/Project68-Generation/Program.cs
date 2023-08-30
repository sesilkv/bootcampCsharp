using System;
using System.Diagnostics;

class Program
{
	static void Main(string[] args)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		
		for(int i = 0; i < 10000; i++)
		{
			MyClass1 obj1 = new MyClass1();
			MyClass2 obj2 = new MyClass2();
			MyClass3 obj3 = new MyClass3();
		}
		
		stopwatch.Stop();
		Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
		
		Console.Read();
	}
}

public class MyClass1
{
	
}

public class MyClass2
{
	
}

public class MyClass3
{
	
}