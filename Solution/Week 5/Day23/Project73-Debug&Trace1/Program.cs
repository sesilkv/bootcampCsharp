using System.Diagnostics;

class Program 
{
	static void Main()
	{
		int userID = 123;
		string pass = "pw";
		
		//muncul di debug console, bukan terminal biasa
		Debug.WriteLine($"{userID} {pass}");
		Trace.WriteLine("UserID and password inserted");
		
		// muncul di terminal biasa jika false
		Debug.Assert(true, "DebugAssert says, I am watching!");
		Trace.Assert(true, "TraceAssert says, I am watching!");
		
		Console.WriteLine("Finish");
		Console.ReadLine();
	}
}