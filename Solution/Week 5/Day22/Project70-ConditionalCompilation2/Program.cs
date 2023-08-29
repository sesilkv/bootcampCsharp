//using <DefineConstant> on the .csproj inside <PropertyGroup>

class Program 
{
	static void Main()
	{
		#if WINDOWS
		Console.WriteLine("WINDOWS");
		#elif LINUX
		Console.WriteLine("LINUX");
		#endif
		Console.WriteLine("Program is loading...");
	}
}