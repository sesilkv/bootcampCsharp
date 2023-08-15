using System;
namespace LaptopLibrary;

class Program
{
	static void Main(string[] args)
	{
		Laptop laptop = new Laptop("HP", "T665", 156);
		Console.WriteLine(laptop.merk);
		// laptop.screenSize = 170;
		Console.WriteLine(laptop.screenSize);
	}
}

class Laptop
{
	private string _merk;
	private string _type;
	private int _screenSize;
	
	public Laptop(string merk, string type, int screenSize)
	{
		_merk = merk;
		_type = type;
		_screenSize = screenSize;
	}
	
	public string merk 
	{
		get 
		{
			return _merk;
		}
		set
		{
			_merk += value;
		}
	}
	
	public int screenSize 
	{
		get 
		{
			return _screenSize;
		}
		set
		{
			_screenSize = value;
		}
	}
	
	
}