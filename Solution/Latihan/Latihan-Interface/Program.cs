class Program 
{
	static void Main(string[] args)
	{
		Pig pig = new();
		Animal animal = new(pig);
		animal.Moving();
	}
}

public interface IAnimal 
{
	void AnimalSound();
	void AnimalPlace();
}

public class Pig:IAnimal
{
	public void AnimalSound()
	{
		Console.WriteLine("ngok ngok");
	}
	public void AnimalPlace()
	{
		Console.WriteLine("Kandang");
	}
}

public class Animal
{
	public IAnimal animal;
	
	public Animal(IAnimal animal)
	{
		this.animal = animal;
	}
	
	public void Moving()
	{
		animal.AnimalSound();
		animal.AnimalPlace();
	}
}