namespace StrangerThings;

public interface IJump
{
	void Jump();
}
public interface IScream
{
	void Scream();
}
public interface IAttack
{
	void Attack();
}
public interface IFly
{
	void Fly();
}
public interface IChase
{
	void Chase();
	void Chase(string name);
}
public interface IMonster : IAttack, IScream, IChase
{
}

public class Kuyang : IFly, IAttack
{
	public void Fly()
	{
		Console.WriteLine("Kuyang is flying");
	}
	public void Attack()
	{
		Console.WriteLine("Kuyang is attacking");
	}
}
public class Pocong : IJump 
{
	public void Jump()
	{
		Console.WriteLine("Pocong is jumping");
	}
}

public class Monster : IMonster
{
	public void Attack()
	{
		Console.WriteLine("Monster is attacking");
	}
	public void Scream()
	{
		Console.WriteLine("Monster is screaming");
	}
	//overload
	public void Chase()
	{
		Console.WriteLine("Monster is chasing");
	}
	public void Chase(string name)
	{
		Console.WriteLine($"Monster is chasing {name}");
	}
}