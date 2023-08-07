class Program
{
	static void Main()
	{
		int number1 = 10;
	
		MultiplyAndAddByTwo(ref number1, out int number2);
		Console.WriteLine(number1);
		Console.WriteLine(number2);

		//FillNumber(out int number3);
		//declare bisa kosongan
		int number3;
		FillNumber(out number3);
	}

	static void MultiplyAndAddByTwo(ref int x, out int y)
	{
		y = 2;
		x = x + 1;
	}
	static void FillNumber(out int number3) 
	{
		number3 = 3;
	}
}