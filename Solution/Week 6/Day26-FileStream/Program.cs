using System.IO;

class Program
{
	static void Main()
	{
		string file1 = @"..\Day26-FileStream\test.txt";
		string file2 = @"..\Day26-FileStream\lalala.txt";
		
		// file
		Console.WriteLine(File.Exists(file2) ? "File exists" : "File doesn't exist");
		
		// FileStream
		
		
		// StreamWriter
		if(!File.Exists(file1))
		{
			using (StreamWriter sw = new StreamWriter(file1, true))
			{
				// sw.WriteLine("Hai");
				sw.WriteLine("Semua");
			}
		}
		
		using (StreamReader sr = new StreamReader(file1))
		{
			string check;
			while ((check = sr.ReadLine()) != null)
			{
				Console.WriteLine(check);
			}
		}
		
		
	}
	
	// static void CreateFile()
	// {
		
	// }
}