class Program {
	static void Main() {
		Calculator calc = new(54);
		Console.WriteLine(Calculator.phi);
		// int calc.x = 15;
		Console.WriteLine(calc.x);
	}
}
class Calculator{
	public const float phi = 3.14f; //static & must assign the value
	public readonly int x; //can empty, modified it from Constructor
	public Calculator(int value) {
		x = value;
	}	
}