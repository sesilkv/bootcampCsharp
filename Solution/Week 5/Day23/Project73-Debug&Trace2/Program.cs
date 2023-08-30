using System.Diagnostics;

class Program
{
	static void Main()
	{
		int x = 11, y = 15;
		
		Debug.WriteLine("Starting program...");
		Debug.WriteLine ($"x = {x}");
		Debug.WriteLine($"y = {y}");
		
		Trace.WriteLine("Calculating x + y ...");
		int res = x+y;
		Trace.WriteLine($"x + y = {res}");
		
		// Debug.Assert(res == 25, $"The result of {x} and {y} should be 25");
		
		Console.Read();
	}
}