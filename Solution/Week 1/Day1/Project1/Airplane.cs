namespace Transportation;

public class Airplane
{
	public string? name;
	public string? type;
	public int numberOfSeats;
	public string? destination;
	
	public void ChangeSpeed()
	{
		Console.WriteLine("Speed changed");
	}
}