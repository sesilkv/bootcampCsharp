namespace Animal;

//as a blueprint (rancangan)
public class Cat //PascalCase
{
	//Variable with camelCase
	public bool isSmoothFur;
	public string? name;
	public bool isMale;
	public int age;
	public bool isOwned;
	public string? colour;
	
	//Method/Behaviour/Function with PascalCase
	public void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
	public void Scratch()
	{
		Console.WriteLine("Scratch");
	}
	public void Sleep()
	{
		Console.WriteLine("Sleep");
	}
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
}