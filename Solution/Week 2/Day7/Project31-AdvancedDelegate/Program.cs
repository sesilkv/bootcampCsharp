using System;

public delegate void PlayerAction();
static class Program
{
	static void Main(string[] args)
	{
		PlayerAction jumpAction = Jump;
		PlayerAction runAction = Run;
		PlayerAction swimAction = Swim;

		Console.WriteLine("\nChoose an action (J for Jump, R for Run, S for Swim):");
		char input = ' ';

		while (input != 'X')
		{
			input = Char.ToUpper(Console.ReadKey().KeyChar);
			switch (input)
			{
				case 'J':
					PerformAction(jumpAction);
					break;
				case 'R':
					PerformAction(runAction);
					break;
				case 'S':
					PerformAction(swimAction);
					break;
				default:
					Console.WriteLine("\nInvalid input. Please press J, R, or S.");
					break;
			}
		}
	}

	// Player action methods
	static void Jump()
	{
		Console.WriteLine("\nThe player is jumping.");
	}
	static void Run()
	{
		Console.WriteLine("\nThe player is running.");
	}

	static void Swim()
	{
		Console.WriteLine("\nThe player is swimming.");
	}

	// PerformAction method
	static void PerformAction(PlayerAction a)
	{
		a();
	}
}