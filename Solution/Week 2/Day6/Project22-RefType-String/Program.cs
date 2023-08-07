using System.Diagnostics;
using System.Text;

public class Program
{
	static void Main()
	{
		int iterations = 10000;
		string resultString = "";
		StringBuilder resultStringBuilder = new StringBuilder();
		
		Stopwatch stopwatch1 = Stopwatch.StartNew();
		for (int i = 0; i < iterations; i++)
		{
			resultString += "a";
		}
		stopwatch1.Stop();
		
		Console.WriteLine($"Time String : {stopwatch1.ElapsedMilliseconds} ms");

		Stopwatch stopwatch2 = Stopwatch.StartNew();
		for (int i = 0; i < iterations; i++)
		{
			resultStringBuilder.Append("a");
		}
		stopwatch2.Stop();
		
		Console.WriteLine($"Time SB: {stopwatch2.ElapsedMilliseconds} ms");
		Console.ReadLine();
	}
}