class Program {
	static void Main()
	{
		Console.WriteLine("Hello");
		try
		{
			Divide(10, 0);
		} catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	
	static void Divide(int x, int y)
	{
		int z = x/y;
	}
}