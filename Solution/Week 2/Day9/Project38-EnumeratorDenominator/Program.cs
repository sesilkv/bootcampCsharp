using System.Collections; // for IEnumerator

class Program
{
	static void Main(string[] args)
	{
		int[] numbers = { 1, 2, 3, 4, 5 };
		
		IEnumerator enumerator = numbers.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Console.WriteLine(enumerator.Current);
		}
	}
}