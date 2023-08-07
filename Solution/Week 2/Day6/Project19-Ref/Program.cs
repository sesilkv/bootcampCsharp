
class Program
{
	static void Main()
	{
		//MUST HAVE assign value
		int number = 1;
		// string hello = "";
		// int result = MultiplyByTwo(number);
		// Console.WriteLine(result); 
		
		bool status = MultiplyByTwoRef(ref number);
		Console.WriteLine(number + " " + status); 
	}
	static int MultiplyByTwo(int x) 
	{
		return x = x * 2;
	}
	static bool MultiplyByTwoRef(ref int x)
	{
		if (x>0)
		{
			x=x * 2;
			return true;
		}
		return false;
	}
}