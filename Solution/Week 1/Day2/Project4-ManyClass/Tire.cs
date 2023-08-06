 namespace CarLibrary;
 
 public class Tire 
 {
 	public int tireSize;
	public string? tireType;
	
	public void CheckTireSize()
	{
		Console.WriteLine($"Size of the tire is {tireSize}");
	}
	public void CheckTireType()
	{
		Console.WriteLine($"The tire type is {tireType}");
	}
 }