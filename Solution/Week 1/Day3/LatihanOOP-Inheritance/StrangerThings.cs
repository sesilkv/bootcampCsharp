namespace StrangerThingsLibrary;

class StrangerThings
{
	public string? name;
	//ENCAP
	protected int _deadTime; //child bisa akses
	private int _age; //just parent 

	//CONSTRUCTOR
	public StrangerThings()
	{
	}
	public StrangerThings(string name, int deadTime, int age)
	{
		this.name = name;
		_deadTime = deadTime;
		_age = age;
	}
	
	public int GetDeadTime()
	{
		return _deadTime;
	}
	
	//Will be overriden
	public virtual void Attack()
	{
		Console.WriteLine("Default attack");
	}

	//OVERLOADING
	public void MakeSound()
	{
		Console.WriteLine("Make No Sound");
	}
	public void MakeSound(string sound)
	{
		Console.WriteLine($"{sound}");
	}
	public void MakeSound(string name, string sound)
	{
		Console.WriteLine($"{name} is {sound}");
	}
}

class Pocong : StrangerThings
{
	public string? gender;
	//Override parent method
	public override void Attack()
	{
		Console.WriteLine("Pocong jump");
	}
	public int GetDeadTime()
	{
		return _deadTime;
	}
}

class Kunti : StrangerThings
{
	//Override parent method
	public override void Attack()
	{
		Console.WriteLine("Kunti fly");
	}
}

class Genderuwo : StrangerThings
{
	public int GetDeadTime()
	{
		return _deadTime;
	}
}

class Zombie : StrangerThings
{
	public string? gender;
	//Override parent method
	public override void Attack()
	{
		Console.WriteLine("Zombie run");
	}
}