using Animal;
using Electronic;
using Transportation;

class Program 
{
	static void Main()
	{
		Console.WriteLine("Hello World\n");
		
		//object/instance
		Cat cat = new Cat();
		cat.isSmoothFur = true;
		cat.isMale = false;
		cat.isOwned = true;
		if(cat.isSmoothFur == true) 
		{
			Console.WriteLine("Cat's fur is smooth");
		}
		if(cat.isMale == true)
		{
			Console.WriteLine("Cat is male");
		} else 
		{
			Console.WriteLine("Cat is female");
		}
		
		// OR statement: jika salah satu true, akan menghasilkan true
		if(cat.isMale || cat.isSmoothFur)
		{
			Console.WriteLine("Cat isn't male"); //output yg ini
		} else 
		{
			Console.WriteLine("Cat is female and have smooth fur");
		}
		
		//AND statement: jika salah satu false, akan menghasilkan false
		if(cat.isSmoothFur == false && cat.isOwned == true)
		{
			Console.WriteLine("That cat is owned by me and don't have smooth fur");
		} else 
		{
			Console.WriteLine("That cat is owned by me and have smooth fur");
		}
		
		cat.name = "Lily";
		// string name = cat.name;
		Console.WriteLine($"Its name is {cat.name}");
		
		cat.age = 5;
		// int age = cat.age;
		Console.WriteLine($"{cat.name}'s age is {cat.age} years old");
		
		cat.colour = "red";
		// string colour = cat.colour;
		Console.WriteLine($"{cat.name}'s fur is {cat.colour}");
		Console.WriteLine($"Sesil have a cat. Its name is {cat.name} and its age is {cat.age} years old. {cat.name} have {cat.colour} fur.\n");
		cat.MakeSound();
		cat.Scratch();
		cat.Sleep();
		cat.Eat();
		
		Television tele = new();
		tele.merk = "LG";
		tele.type = "Android TV";
		tele.channel = 9;
		Console.WriteLine($"Channel of {tele.merk} is {tele.channel}");
		tele.volume = 35;
		Console.WriteLine($"Volume of {tele.merk} right now is {tele.volume}");
		tele.isOn = true;
		if(tele.isOn  == true)
		{
			Console.WriteLine($"{tele.merk} TV with {tele.type} type is on");
		}
		tele.SetVolume();
		tele.SetChannel();
		tele.TurnOn();
		tele.TurnOff();
		
		Airplane plane = new();
		plane.name = "Lion Air";
		plane.type = "Boeing 777";
		plane.destination = "Bali";
		plane.numberOfSeats = 50;
		Console.WriteLine($"{plane.name} with the {plane.type} type has destination to {plane.destination} with {plane.numberOfSeats} seats");
		plane.ChangeSpeed();
	}
}