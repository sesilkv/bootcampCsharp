public delegate void MyDelegate(string message);

class Publisher 
{
	
}

class Subscriber 
{
	public void Notification(string message);
	{
		Console.WriteLine($"{message}");
	}
}

class Program
{
	static void Main()
	{
		Publisher publisher = new();
		Subscriber sub1 = new();
		Subscriber sub2 = new();
		
		publisher.
	}
}
