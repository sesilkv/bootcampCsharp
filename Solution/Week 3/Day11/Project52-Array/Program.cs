class Program
{
	static void Main()
	{
		int[] arrayInt = {1, 2, 3};
		
		for(int i = 0; i < arrayInt.Length; i++)
		{
			Console.WriteLine(arrayInt[i]);
		}
		
		Console.WriteLine(arrayInt[1]);
		
		//change data on index 1
		arrayInt[1] = 5;
		Console.WriteLine(arrayInt[1]);
		
		Console.WriteLine(arrayInt.Length);
		
		foreach(int x in arrayInt)
		{
			Console.WriteLine(x);
		}
		
		//dimensi
		Console.WriteLine(arrayInt.Rank);
	}
}

//ARRAY type safety and fix size