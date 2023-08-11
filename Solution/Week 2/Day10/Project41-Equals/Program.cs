//Equals Comparison

class Animal
{
	private string _name;

	public Animal(string name)
	{
		_name = name;
	}
	public string GetName()
	{
		return _name;
	}

	public override bool Equals(object x)
	{
		if(x.GetType() == this.GetType())
		{
			return _name = ((Animal)x.GetName());
		}
		return false;
	}
}

class Program
{
	static void Main()
	{
		Animal anim1 = new Animal("cuit");
		Animal anim2 = new Animal("guk");
		Console.WriteLine(anim1.Equals(anim2));
	}
}

//Equal Comparison
// using System;
// class Program
// {
// 	static void Main()
// 	{
// 		var car1 = new Car(5);
// 		var car2 = new Car(5);
// 		//int x = 5;

// 		//(car1 == car2).Dump();
// 		Console.WriteLine(car1.Equals(car2));
// 	}
// }
// class Animal
// {
// 	private string _;
// 	public Car(int x)
// 	{
// 		_id = x;
// 	}
// 	public int GetID()
// 	{
// 		return _id;
// 	}
// 	public override bool Equals(object x)
// 	{
// 		if (x == null)
// 		{
// 			return false;
// 		}
// 		if ((x.GetType() == this.GetType()))
// 		{
// 			return _id == ((Car)x).GetID();
// 		}
// 		return false;
// 	}
// }