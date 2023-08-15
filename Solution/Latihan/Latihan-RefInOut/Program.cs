class Program
{
	static void Main()
	{
		int numb = 1;
		int num;
		Console.WriteLine(numb);
		MethodRef(ref numb);
		Console.WriteLine(numb);
		
		MethodIn(in numb);
		Console.WriteLine(numb);
		
		MethodOut(out num);
		Console.WriteLine(num);
	}
	
	static void MethodRef(ref int x)
	{
		x = 2;
	}
	
	static void MethodIn(in int y)
	{
		Console.WriteLine(y*3);
	}
	
	static void MethodOut(out int z)
	{
		z = 5;
	}
}