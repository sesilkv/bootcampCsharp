class Program 
{
	static void Main()
	{
		int x = 5;
		object obj1 = x; //boxing
		int y = (int) obj1; //unboxing
		Console.WriteLine(y);
		
		int a = 10;
		object obj2 = a;
		string str = ((int)obj2).ToString();
		Console.WriteLine(str);
		
		//UPCAST
		int c = 11;
		object obj3 = c;
		//long d = (long)(int)obj3; 
		long d = (int)obj3;
		Console.WriteLine(d);

		//EXPLICIT DOWNCAST
		float e = 12.2f; //tipe data lebih besar
		object obj6 = e;
		//int i = (int)obj6; 
		int i = (int)(float)obj6;
		Console.WriteLine(i);
		
		object obj4 = "Hello, World! 1";
		if (obj4 is string)
		{
			string str4 = (string) obj4;
			Console.WriteLine(str4);
		}

		object obj5 = "Hello, World! 2";
		if (obj5 is string str5) //pattern matching
		{
			Console.WriteLine(str5);
		}

		object obj7 = 67;
		int j = obj7 as int? ?? 0;
		Console.WriteLine(j);
	}
}