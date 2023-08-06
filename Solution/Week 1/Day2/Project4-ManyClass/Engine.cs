namespace CarLibrary;

public class Engine 
{
	public string? engineType;
	
	public void EngineRun()
	{
		Console.WriteLine($"Running {engineType}");
	}
	public void EngineOilCheck()
	{
		Console.WriteLine($"Checkin oil {engineType}");
	}
	public void EngineStop()
	{
		Console.WriteLine($"Stopping {engineType}");
	}
	
}