class Program
{
	static void Main()
	{
		// Console.WriteLine("Hello");
		try
		{
			Array();
			Divide(10, 0);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	static void Divide(int x, int y)
	{
		int z = x / y;
	}

	static void Array()
	{
		int[] num = { 1, 2, 3, 4 };
		Console.WriteLine(num[2]);
	}
}