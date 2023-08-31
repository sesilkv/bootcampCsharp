using System.Diagnostics; // for stopwatch

class Program 
{
	static void Main()
	{
		Console.WriteLine("Starting program...");
		
		var stopwatch = new Stopwatch();
		stopwatch.Start();
		
		Thread t1 = new Thread(DoTaskOne);
		Thread t2 = new Thread(DoTaskTwo);
		
		t1.Start();
		t2.Start();
		
		t1.Join();
	}
	
	static void DoTaskOne()
	{
		
	}
	
	static void DoTaskTwo()
	{
		
	}
}