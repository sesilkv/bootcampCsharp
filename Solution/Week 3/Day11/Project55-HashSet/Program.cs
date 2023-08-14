//HASH SET
class Program
{
	static void Main()
	{
		HashSet<int> hash = new();
		hash.Add(5);
		hash.Add(54);
		hash.Add(8);
		hash.Add(9);
		hash.Add(54);
		
		Console.WriteLine(hash);
	}
}

