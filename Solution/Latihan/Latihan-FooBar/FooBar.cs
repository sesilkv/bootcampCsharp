namespace FooBarLibrary;

public class FooBar
{
	public void Foobar()
	{
		Console.WriteLine("Input the value: ");
		int input = int.Parse(Console.ReadLine());

		for (int x = 0; x <= input; x++)
		{
			if (x > 0)
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
			else
			{
				Console.WriteLine(x);
			}
		}
	}
}