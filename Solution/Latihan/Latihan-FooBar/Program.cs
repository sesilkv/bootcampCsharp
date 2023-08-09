class Program
{
	static void Main(string[] args)
	{
		FooBar();
	}

	static void FooBar()
	{
		Console.WriteLine("Input the value: ");
		// string input = Console.ReadLine();
		int input = int.Parse(Console.ReadLine());

		for (int x = 0; x <= input; x++)
		{
			if (x % 3 == 0 && x % 5 == 0)
			{
				Console.WriteLine("FooBar");
			}
			else if (x % 5 == 0)
			{
				Console.WriteLine("Bar");
			}
			else if (x % 3 == 0)
			{
				Console.WriteLine("Foo");
			}
			else
			{
				Console.WriteLine(x);
			}
		}
	}
}
