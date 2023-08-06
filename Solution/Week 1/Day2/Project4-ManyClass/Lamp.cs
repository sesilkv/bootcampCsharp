namespace CarLibrary;

public class Lamp 
{
	public string? lampType;
	
	//CONSTRUCTORS
	public Lamp(string LampType)
	{
		this.lampType = LampType;
	}
	
	//METHOD
	public void TurnOn()
	{
		Console.WriteLine($"Turning {lampType}");
	}
}