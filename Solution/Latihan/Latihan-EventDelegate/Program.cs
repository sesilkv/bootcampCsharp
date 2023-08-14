//Delegate and Event			
public delegate void NotifikasiTemperature (int x);
class Suhu
{
	public event NotifikasiTemperature nt;
	public int x;
	
	public Suhu() {
	
	}
	public void Celcius(int suhu)
	{
		Console.WriteLine("Suhu sekarang" + suhu + "C");
	}
	public void Fahrenheit(int suhu)
	{
		Console.WriteLine("Suhu Fahrenheit" + suhu + "F");	
	}
	public void RunNT(int x) {
		nt.Invoke(x);
	}
}
class Program 
{
	static void Main() 
	{
		Suhu suhu = new();
		//NotifikasiTemperature nt;
		suhu.nt += suhu.Celcius;
		suhu.nt += suhu.Fahrenheit;
		suhu.RunNT(15);
		//suhu.Celcius(30);
		//suhu.Fahrenheit(40);
	}
}
	