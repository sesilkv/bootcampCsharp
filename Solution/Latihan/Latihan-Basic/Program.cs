namespace BelajarCSharp;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World");
		string? name = Console.ReadLine();
		Console.WriteLine($"Halo, {name}! Selamat datang!");
		Console.WriteLine("Press any key to continue...");
		
		//Agar program tidak langsung menutup
		Console.ReadKey();
	}
}