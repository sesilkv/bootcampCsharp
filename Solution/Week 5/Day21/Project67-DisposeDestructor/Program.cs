using System;

class Program 
{
	static void Main(string[] args)
	{
		// use object with using statement
		using (var obj1 = new MyClass())
		{
			Console.WriteLine("Using object with 'using' statement");
		}
		
		// without using statement
		var obj2 = new MyClass();
		Console.WriteLine("Using object without 'using' statement");
		obj2.Dispose();
		
		// create object and explicit remove
		var obj3 = new MyClass();
		Console.WriteLine("Creating and disposing object explicitly...");
		obj3.Dispose();
		
		// create object without calling dispose/GC
		var obj4 = new MyClass();
		Console.WriteLine("Creating object without disposing or finalizing it...");
		obj4 = null;
		
		Console.Read();
	}
}

class MyClass : IDisposable
{
	private bool disposed = false;
	
	private void CleanupUnmanagedResources()
	{
		Console.WriteLine("Cleaning up managed resources...");
	}
	
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this); // to prevent a redundant garbage collection from being called
	}
	
	protected virtual void Dispose(bool disposing)
	{
		if(disposed)
		{
			return;
		}
		if(disposing)
		{
			Console.WriteLine("Disposing managed resource...");
		}
		CleanupUnmanagedResources();
		
		disposed = true;
	}
	
	~MyClass()
	{
		Console.WriteLine("Finalizing object...");
		Dispose(false);
	}
}