class Program
{
	static void Main()
	{
		int number = 10;
		PrintDouble(in number);
	}

	static void PrintDouble(in int x)
	{
		//int x = 5; readonly tidak bisa diubah valuenya
		Console.WriteLine(x * 2);
	}
}