using System;
using System.Xml;
class Program
{
	static void Main()
	{
		// Parsing hexadecimal string to int
		int hexToInt = Convert.ToInt32("1E", 16); // Parse in hexadecimal (30)
		Console.WriteLine(hexToInt); // Output: 30

		// Parsing binary string to integer
		int five = Convert.ToInt32("101", 2); // Parse in binary (5)
		Console.WriteLine(five); // Output: 5

		// Using dynamic data type for implicit conversion
		dynamic a = 1;
		a = "1";
		dynamic myInt = 123;
		dynamic myString = "456";
		
		// Convert int to a string
		myString = myInt.ToString();  
		Console.WriteLine(myString); // Output: "123"

		// Convert string to an integer
		bool convertStringtoInt = int.TryParse(myString, out int intParse);
		Console.WriteLine(intParse + " " + convertStringtoInt); // Output: 456 true

		// Convert int to a double
		double  myDouble = intParse;
		Console.WriteLine(myDouble); // Output: 123.0

		// Converting data types using Convert.ChangeType method
		Type targetType = typeof(int);
		object source = "42";
		object result = Convert.ChangeType(source, targetType);
		int x = (int)result;
		Console.WriteLine(x); // Output: 42
		Console.WriteLine(result.GetType()); // Output: System.Int32
	}
}