//CONSTRUCTOR DAN GET SET METHOD

class Program
{
	static void Main(string[] args)
	{
		Car car1 = new Car("Honda", 15);
		Console.WriteLine(car1.GetBrand());
		Console.WriteLine(car1.SetBrand("Toyota"));
		
		Console.WriteLine(car1.GetID());
		Console.WriteLine(car1.SetID(10));
	}
}

public class Car
{
	private string? _brand;
	private int? _id;

	//CONSTRUCTOR
	public Car(string brand, int id)
	{
		_brand = brand;
		_id = id;
	}

	//GET METHOD
	public string? GetBrand()
	{
		return _brand;
	}
	public int? GetID()
	{
		return _id;
	}

	//SET METHOD
	public string? SetBrand(string brand)
	{
		_brand = brand;
		return _brand;
	}
	public int? SetID(int id)
	{
		_id = id;
		return _id;
	}


}