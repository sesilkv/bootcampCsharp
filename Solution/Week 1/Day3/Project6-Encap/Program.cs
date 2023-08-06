using HumanLibrary;
class Program 
{
	static void Main()
	{
		Human sesil = new("Sesil", 23, 1000);
		Human aziz = new("Aziz", 24, 1500);
		
		Console.WriteLine(sesil.GetAge());
		Console.WriteLine(aziz.GetAge());
		
		Console.WriteLine(sesil.SetAge(25));
	}
}