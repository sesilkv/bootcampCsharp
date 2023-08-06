namespace AnimalLibrary;
class Animal 
{
	//OVERRIDE
	public virtual void MakeSound()
	{
		Console.WriteLine("Making sound");
	}
	
	//OVERLOAD
	public void Eat()
	{
		Console.WriteLine("Eat default");
	}
	public void Eat(string food)
	{
		Console.WriteLine($"Eat : {food}");
	}
	public void Eat(string food, int x)
	{
		Console.WriteLine($"Eat {food} for {x} times");
	}
}

//OVERRIDE
class Cat:Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
}

class Dog:Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}

//KOSONG, MENGIKUTI PARENT
class Ant:Animal
{

}