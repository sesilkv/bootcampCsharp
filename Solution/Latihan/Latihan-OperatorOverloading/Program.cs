class Number 
{
	public int number;
	
	//constructor
	public Number(int number)
	{
		this.number = number;
	}
	
	//operator overloading
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

class String 
{
	public string myString;
	public String(string str)
	{
		myString = str;
	}
	public static String operator +(String str1, String str2)
	{
		string result = str1.myString + str2.myString;
		return new String(result);
	}
}

class Program 
{
	static void Main()
	{
		Number num1 = new(1);
		Number num2 = new(2);
		Number num3 = new(3);
		Number addNumb = num1 + num2 + num3;
		// Number subtractNumb = num1 - num2 - num3;
		// Number mulNumb = num1 * num2 * num3;
		// Number divNumb = num1 / num2 / num3;
		Console.WriteLine(addNumb.number);
		// Console.WriteLine(subtractNumb.number);
		// Console.WriteLine(mulNumb.number);
		// Console.WriteLine(divNumb.number);
		
		String str1 = new("Sesilia");
		String str2 = new("Kirana");
		String str3 = new("Vaniamosa");
		String addStr = str1 + str2 + str3 ;
		Console.WriteLine(addStr.myString);
	}
}