public enum Rainbow
{
	Merah,
	Jingga,
	Kuning,
	Hijau,
	Biru,
	Nila,
	Ungu
}

class Program
{
	static void Main()
	{
		Rainbow color = Rainbow.Kuning;
		switch (color)
		{
			case Rainbow.Kuning:
				Console.WriteLine("This is yellow");
				break;
			case Rainbow.Biru:
				Console.WriteLine("Blue!");
				break;
			case Rainbow.Merah:
				Console.WriteLine(Rainbow.Merah);
				break;
			default:
				Console.WriteLine(Rainbow.color);
		}
	}
}