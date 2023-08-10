class Program 
{
	static void Main()
	{
		//defines the code to run
		try
		{
			int a = 10;
			int b = int.Parse(Console.ReadLine());
			int c= a/b;
		}
		//defines the code to handle any error
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		//defines the code to run regardless of the result
		finally 
		{
			Console.WriteLine("final");
		}
	}
}