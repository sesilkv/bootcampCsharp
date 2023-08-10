class Number 
{
	public int number;
	
	//constructor
	public Number(int number)
	{
		this.number = number;
	}
	
	public static Number operator +(Number num1, Number num2)
	{
		int res = num1.number + num2.number;
		return new Number(res);
	}
	
	public static Number operator -(Number num1, Number num2)
	{
		int res = num1.number - num2.number;
		return new Number(res);
	}
		
	public static Number operator *(Number num1, Number num2)
	{
		int res = num1.number * num2.number;
		return new Number(res);
	}
	
	//jika ingin mengubah hasil ke float, dari awal diubah dulu ke float
		
	// public static Number operator /(Number num1, Number num2)
	// {
	// 	float res = (float)num1.number / num2.number;
	// 	return new Number(res);
	// }
}

class Program 
{
	static void Main()
	{
		Number num1 = new(1);
		Number num2 = new(2);
		Number num3 = new(3);
		Number addNumb = num1 + num2 + num3;
		Number subtractNumb = num1 - num2 - num3;
		Number mulNumb = num1 * num2 * num3;
		// Number divNumb = num1 / num2 / num3;
		Console.WriteLine(addNumb.number);
		Console.WriteLine(subtractNumb.number);
		Console.WriteLine(mulNumb.number);
		// Console.WriteLine(divNumb.number);
	}
}