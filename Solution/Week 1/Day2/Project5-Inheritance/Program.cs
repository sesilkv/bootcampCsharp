using AnimalLibrary;

class Program 
{
	static void Main(string[] args)
	{
		Bird bird = new();
		bird.age = 6;
		int birdAge = bird.age;
		Console.WriteLine(birdAge);
		bird.Eat();
		bird.Fly();
		// bool bird.isMale = true;
		
		Cat cat = new();
		cat.name = "Lala";
		Console.WriteLine($"The cat's name is {cat.name}");
		cat.Sleep();
		
		Turtle turtle = new();
		turtle.Swim();
		
	}
}