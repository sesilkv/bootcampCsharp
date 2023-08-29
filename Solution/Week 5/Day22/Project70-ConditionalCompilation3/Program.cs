// Jika dirun auto ke Debug
// dotnet build -c ...... (folder name)

// #define DEVELOPMENT > ga ngaruh
class Program 
{
	static void Main()
	{
		#if DEBUG
		Console.WriteLine("Debug is activated");
		#elif PRODUCTION
		Console.WriteLine("Production is activated");
		#elif DEVELOPMENT
		Console.WriteLine("Development is activated");
		#else
		Console.WriteLine("Not found");
		#endif
		Console.WriteLine("Program is loading...");
		
		Console.ReadLine();
	}
}