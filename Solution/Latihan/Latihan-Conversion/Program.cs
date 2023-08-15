namespace ConversionTypeCasting;
class Program 
{
	static void Main(string[] args)
	{
		//implicit
		int x = 10;
		Console.WriteLine(x);
		double y = x;
		Console.WriteLine(y);
		
		//explicit
		double j = 10.56;
		Console.WriteLine(j);
		int k = (int)j;
		Console.WriteLine(k);
	}
}