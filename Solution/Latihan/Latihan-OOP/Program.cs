namespace ShapeLibrary;
class Program
{
	static void Main(string[] args)
	{
		Shape shape = new();
		Triangle triangle = new();
		Square square = new();
		Circle circle = new();
		
		shape.MyShape();
		triangle.MyShape();
		square.MyShape();
		circle.MyShape();
		
		Console.WriteLine(square.Hitung(5));
		Console.WriteLine(triangle.Hitung(5, 6));
		Console.WriteLine(triangle.KelilingTriangle(5, 6, 6));
		int x = square.GetSisi(5);
		Console.WriteLine(x);
	}
}

class Shape
{
	private int _sisi;

	public int GetSisi(int sisi)
	{
		return _sisi = sisi;
	}

	//WILL BE OVERRIDEN (virtual - override)
	public virtual void MyShape()
	{
		Console.WriteLine("Ini adalah bangun datar");
	}
	
	//OVERLOAD
	public int Hitung(int sisi)
	{
		return sisi * sisi;
	}
	public int Hitung(int alas, int tinggi)
	{
		return (alas * tinggi) / 2;
	}
}

//INHERIT
class Triangle : Shape
{
	public override void MyShape()
	{
		Console.WriteLine("Ini adalah segitiga");
	}
	public int KelilingTriangle(int alas, int sisi1, int sisi2)
	{
		return alas+sisi1+sisi2;
	}
}

//INHERIT
class Square : Shape
{
	public override void MyShape()
	{
		Console.WriteLine("Ini adalah persegi");
	}
}

//INHERIT
class Circle : Shape
{
	public override void MyShape()
	{
		Console.WriteLine("Ini adalah lingkaran");
	}
}