using AnimalLibrary;
class Program 
{
	static void Main()
	{
		Animal animal = new Animal();
		Cat cat = new Cat();
		Dog dog = new Dog();
		Ant ant = new Ant();
		
		//OVERRIDE
		animal.MakeSound();
		cat.MakeSound();
		dog.MakeSound();
		ant.MakeSound();
		
		//OVERLOAD
		animal.Eat();
		animal.Eat("meat");
		animal.Eat("fruit", 3);
		dog.Eat("tempe", 5);
		
	}
}