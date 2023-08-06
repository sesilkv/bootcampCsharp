using StrangerThings;

public class Program
{
	static void Main()
	{
		Monster troll = new();
		IMonster monster = troll;
		monster.Attack();
		monster.Chase();
		monster.Chase("her");
		monster.Scream();
		
		Kuyang kuyang = new();
		IFly kuyangf = kuyang;
		kuyangf.Fly();
	}
}