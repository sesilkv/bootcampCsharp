public delegate int Calculator(int x, int y);

class Program
{
	static void Main()
	{
		Calculator operation = Program.Add;
		int add = operation (2, 3);
		Console.WriteLine(add);
		
		operation = Program.Multiply;
		int multiply = operation(2, 3);
		Console.WriteLine(multiply);
	}
	
	
	public static int Add(int x, int y)
	{
		return x+y;
	}
	public static int Multiply(int x, int y)
	{
		return x*y;
	}
	public static int Subtract(int x, int y)
	{
		return x-y;
	}
	public static int Divide(int x, int y)
	{
		return x/y;
	}
}