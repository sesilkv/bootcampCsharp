namespace Animal;

public class Cat 
{
	//Variable
	public string? name;
	public int age;
	
	//Method parameterless
	public void MakeSound()
	{
		Console.WriteLine("Cat is making sound");	
	}
	
	//Method with parameter
	public void Eat(string food)
	{
		Console.WriteLine($"Cat eat {food}");
	}
}