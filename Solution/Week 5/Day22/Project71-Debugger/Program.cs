class Program 
{
	static void Main()
	{
		double x = 10.0;
		double y = 2.5;
		double result = Add(x, y);
		
		Console.WriteLine($"The result of {x} + {y} is {result}");
	}
	
	static double Add(double x, double y)
	{
		return x + y;
	}
}