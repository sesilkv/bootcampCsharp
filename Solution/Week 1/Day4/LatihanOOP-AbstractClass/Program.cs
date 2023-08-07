using ShapeLibrary;

class Program 
{
	static void Main(string[] args)
	{
		Square square = new();
		double hasilSquare = square.Hitung; //get
		Console.WriteLine(hasilSquare);
		square.Sisi = 10.5; //set
		Console.WriteLine(square.Luas());
		
		Triangle triangle = new();
		double hasilTriangle = triangle.Hitung; //get
		Console.WriteLine(hasilTriangle);
		triangle.Alas = 10.5; //set
		triangle.Tinggi = 15;
		Console.WriteLine(triangle.Luas());
		
		Circle circle = new();
		double hasilCircle = circle.Hitung; // get
		Console.WriteLine(hasilCircle);
		circle.Sisi = 10; //set
		Console.WriteLine(circle.Luas());
	}
}