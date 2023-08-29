// using define

// #define GAMETESTER
#define GAMESTART
class Program 
{
	static void Main()
	{
		#if GAMESTART
		Console.WriteLine("GameStart");
		#elif GAMERUNNER
		Console.WriteLine("GameRunner");
		#elif GAMETESTER
		Console.WriteLine("GameTester");
		#else
		Console.WriteLine("Not anything");
		#endif
		Console.WriteLine("Finish");
	}
}