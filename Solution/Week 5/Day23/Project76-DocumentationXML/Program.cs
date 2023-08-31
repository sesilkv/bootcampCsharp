using DocumentationXML;

class Program
{
	static void Main(string[] args)
	{
		// MyLib myLib = new MyLib();
		
		double a = 4.0;
		double b = 2.5;
		
		// static can't use instance
		double Add = MyLib.Add(a, b);
		double Multiply = MyLib.Multiply(a, b);
		double Divide = MyLib.Divide(a, b);
		double Subtract = MyLib.Subtract(a, b);
		string res = $"{Add} {Multiply} {Divide} {Subtract}";
		Console.WriteLine($"{a} + {b} = {res}");
	}
}
