using GetSet;

public class Program 
{
	static void Main()
	{
		Car car = new();
		string x = car.name; //get
		Console.WriteLine(x);
		car.name =  "Yusuf"; //set
		Console.WriteLine(car.name);
	}
}