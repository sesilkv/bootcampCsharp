class Program 
{
	static void Main()
	{
		int a = 5;
		Console.WriteLine(a);
		int b = a;
		b = b + 2;
		Console.WriteLine(b);
		
		Value value = new();
		value.a = 5;
		Console.WriteLine(value.a);
		Value value2 = new();
		// int value2 = value.a;
		// Console.WriteLine(value2);
		
		string x = "5";
		string y = x;
		y = y + 2;
		Console.WriteLine(x);
		Console.WriteLine(y);
	}
}

public class Value
{
	public int a;
	// public int b;
}