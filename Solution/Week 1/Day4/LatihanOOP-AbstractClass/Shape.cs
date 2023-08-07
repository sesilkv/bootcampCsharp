namespace ShapeLibrary;

public abstract class Shape 
{
	protected double _hitung;
	
	//GET SET
	public double Hitung
	{
		get { return _hitung; }
		set { _hitung = value; }
	}
	
	// public static void
	
	public abstract double Luas();
}

public class Square:Shape 
{
	private double _sisi;
	public double Sisi
	{
		get { return _sisi; }
		set { _sisi = value; }
	}
	public override double Luas()
	{
		return _hitung = _sisi * _sisi;
	}
}

public class Triangle:Shape 
{
	private double _alas;
	private double _tinggi;
	
	public double Alas 
	{
		get { return _alas; }
		set { _alas = value; }
	}
	public double Tinggi 
	{
		get { return _tinggi; }
		set { _tinggi = value; }
	}
	
	public override double Luas()
	{
		return _hitung = _alas * _tinggi / 2;
	}
}

public class Circle:Shape 
{
	private double _sisi;
	
	public double Sisi
	{
		get { return _sisi; }
		set { _sisi = value; }
	}
	
	public override double Luas()
	{
		return _hitung = 3.14 * _sisi * _sisi;
	}
}