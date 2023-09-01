using System.Threading;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		// initialize cancellation object
		CancellationTokenSource cts = new CancellationTokenSource();
		CancellationToken token = cts.Token;

		Task task = TaskOne(token);
		
		try
		{
			
		}
		catch 
		{
			
		}
	}
	
	static async Task TaskOne(CancellationToken token)
	{
		Console.WriteLine("Task One is starting...");
		for(int x = 0; x < 10; x++)
		{
			token.ThrowIfCancellationRequested();
			
			Console.WriteLine($"Running task {x}");
			await TaskOne.Delay();
		}
	}
}