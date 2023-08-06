namespace AnimalLibrary;

class Animal 
{
	public string? name;
	public int age;
	
	public void Sleep()
	{
		Console.WriteLine("Sleep");
	}
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
	public void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
}

class Bird:Animal 
{
	// public bool isMale;
	
	// public Bird(bool isMale)
	// {
	// 	this.isMale = isMale;
	// }
	public void Fly()
	{
		Console.WriteLine("Bird Fly");
	}
}

class Cat:Animal
{
	public void Scratch()
	{
		Console.WriteLine("Cat Scratch");
	}
}

class Turtle:Animal
{
	public void Swim()
	{
		Console.WriteLine("Turtle Swim");
	}
}