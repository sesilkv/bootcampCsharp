//Static
class Calculator {
	//static tidak bisa dibuat instance
	public static int Add(int a, int b) {
		return a+b;
	}
	public static int Multiply(int a, int b) {
		return a * b;
	}
	
	//harus dibuat instance terlebih dahulu
	public int Divider(int a, int b) {
		return a / b;
	}
	public int Substract(int a, int b) {
		return a - b;
	}
}

class Program {
	static void Main() {
		int x = 3;
		int y = 5;
		Console.WriteLine(Calculator.Add(x,y)); // 8
		Console.WriteLine(Calculator.Multiply(x,y)); //15
		Calculator calc = new();
		Console.WriteLine(calc.Divider(x,y));
		Console.WriteLine(calc.Substract(x,y));
		// Calculator calc = new();
		// calc.Add(x,y); Error, must call it with the class Name
	}
}