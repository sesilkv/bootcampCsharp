class Program 
{
	static void Main()
	{
		//OBJECT BOXING UNBOXING
		//Object bisa membungkus apapun
		int a = 9;
		object obj = a; //boxing
		
		int b = (int)obj; //unboxing
		
		Console.WriteLine(b);
		
		int q = (int)ObjectMaker.MyWrapper(5);
		Console.WriteLine(q);
	}
}

//OBJECT BOXING UNBOXING
static class ObjectMaker 
{
	public static object MyWrapper(int x)
	{
		object z = x;
		return z;
	}
}