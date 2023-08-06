class Program 
{
	static void Main()
	{
		Calculator calc = new();
		int x = 8;
		int y = 6;
		Console.WriteLine(calc.Add(x, y));
		Console.WriteLine(calc.Subtract(x, y));
		Console.WriteLine(calc.Multiplied(x, y));
		Console.WriteLine(calc.Divide(x, y));
	}
}

class Calculator 
{
	public int Add(int x, int y)
	{
		int result = x + y;
		return result;
	}
	public int Subtract(int x, int y)
	{
		int result = x - y;
		return result;
	}
	public int Multiplied(int x, int y)
	{
		int result = x * y;
		return result;
	}
	public int Divide(int x, int y)
	{
		int result = x / y;
		return result;
	}
}