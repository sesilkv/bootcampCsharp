using System;

class Program
{
	static void Main()
	{
		// foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
		// {
		// 	Console.WriteLine(day);
		// }
		
		
		DaysOfWeek today = DaysOfWeek.Monday;
		Console.WriteLine((int)today);
		Console.WriteLine("Today is: " + today);
		switch (today)
		{
			case DaysOfWeek.Sunday:
				Console.WriteLine("Sunday");
				break;
			case DaysOfWeek.Monday:
				Console.WriteLine(DaysOfWeek.Monday);
				break;
			case DaysOfWeek.Tuesday:
				Console.WriteLine("Tuesday");
				break;
		}
		
		
		DaysOfWeek day1 = DaysOfWeek.Monday;
		Console.WriteLine(day1); // output:
		Console.WriteLine((int)day1);  // output:

		string userDays = "Monday";
		DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userDays);
		Console.WriteLine("Parsed enum value : " + day);
		Console.WriteLine("Parsed enum value : " + (int)day);

		Console.WriteLine((int)DaysOfWeek.Monday);
		DaysOfWeek y = (DaysOfWeek)0;
	}
}

public enum DaysOfWeek
	{
		Monday=0,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}