using System;

public delegate void OneDelegate();

class Program
{
	static void Main()
	{
		OneDelegate suka = PrintLike;
		OneDelegate makan = PrintEat;

		OneDelegate sukaMakan = suka + makan;

		sukaMakan();
	}

	static void PrintLike()
	{
		Console.WriteLine("Suka ");
	}

	static void PrintEat()
	{
		Console.WriteLine("Makan");
	}
}