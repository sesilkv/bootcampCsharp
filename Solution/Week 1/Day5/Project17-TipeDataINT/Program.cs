class Program 
{
	static void Main()
	{
		int a = 1;
		int b = 2;
		Console.WriteLine((a+b) == 3); // True 
		
		float c = 0.1f;
		float d = 0.2f;
		Console.WriteLine((c+d) == 0.3f); // True
		Console.WriteLine((c+d));
		
		double e = 0.1d;
		double f = 0.2d; 
		Console.WriteLine((e+f) == 0.3d); // False
		Console.WriteLine((e+f));
		
		decimal g = 0.1M;
		decimal h = 0.2M;
		Console.WriteLine((g+h) == 0.3M); // True 
		Console.WriteLine((g+h));
}
}