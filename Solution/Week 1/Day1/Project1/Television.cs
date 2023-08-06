namespace Electronic;

public class Television 
{
	public string? merk;
	public bool isOn;
	public string? type;
	public int channel;
	public int volume;
	
	public void SetVolume()
	{
		Console.WriteLine("Change Volume");
	}
	public void SetChannel()
	{
		Console.WriteLine("Change Channel");
	}
	public void TurnOn()
	{
		Console.WriteLine("Turn on the TV");
	}
	public void TurnOff()
	{
		Console.WriteLine("Turn off the TV");
	}
}