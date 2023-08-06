using StrangerThingsLibrary;
class Program
{
	static void Main()
	{
		StrangerThings mumun = new StrangerThings("Mumun", 9, 30);
		Pocong pocong = new Pocong();
		Kunti kunti = new Kunti();
		Genderuwo genderuwo = new Genderuwo();
		Zombie zombie = new Zombie();
		
		string gender = zombie.gender = "woman";
		Console.WriteLine($"Zombie is {gender}");

	 	Console.WriteLine(mumun.GetDeadTime() + Environment.NewLine);
		
		//OVERLOAD
		pocong.MakeSound();
		genderuwo.MakeSound("grrrr");
		kunti.MakeSound("Kunti", "hihihi\n");

		//OVERRIDE
		pocong.Attack();
		kunti.Attack();
		genderuwo.Attack();
		zombie.Attack();	

	}
}