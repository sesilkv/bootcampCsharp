class Program 
{
	static void Main(string[] args)
	{
		Parse();
		TryParse();
		// try
		// {
		// 	TryParse();
		// } catch (System.FormatException e) 
		// {
		// 	Console.WriteLine(e.Message);
		// }
	}
	
	//konversi string ke tipe data int
	//PARSE digunakan saat kita yakin akan string yg bersangkutan
	static void Parse()
	{
		string input = "22";
		int x = int.Parse(input);
		Console.WriteLine(x);
	}
	
	//TryParse digunakan saat kita tidak yakin, dan ingin mengecek
	static void TryParse()
	{
		string input = "H";
		bool status = int.TryParse(input, out int x);
		Console.WriteLine(x);
	}
}