class Program 
{
	static void Main()
	{
		DestructorDemo dem1 = new();
		DestructorDemo dem2 = new();
		
		// make dem1 for GC (Garbage Collection)
		dem1 = null;
		GC.Collect(0);
		
		Console.ReadKey();
	}
}

class DestructorDemo
{
	public DestructorDemo()
	{
		Console.WriteLine("Constructor Object created");
	}
	
	~DestructorDemo()
	{
		string type = GetType().Name;
		Console.WriteLine($"Object {type} is Destroyed");
	}
}