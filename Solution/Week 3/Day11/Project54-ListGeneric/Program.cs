//LIST GENERIC
class Program
{
	static void Main()
	{
		List<int> intLists = new();
		intLists.Add(5);
		intLists.Add(54);
		intLists.Add(8);
		intLists.Add(9);
		intLists.Add(10);
		
		Console.WriteLine(intLists.Contains(5));
		
		foreach(int i in intLists)
		{
			Console.WriteLine(i);
		}
		
		Console.WriteLine(intLists.Count);
		
	}
}
//Remove: hapus data
//RemoveAt: hapus index

