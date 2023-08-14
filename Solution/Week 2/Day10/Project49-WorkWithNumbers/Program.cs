using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Maximum value and allowed value types for each data type:");


        BigInteger bigIntMaxValue = BigInteger.Pow(2, 1024) - 1;
        Console.WriteLine($"BigInteger: Maximum value is {bigIntMaxValue}, allowed value types are whole numbers only");

        // int
        int intMaxValue = int.MaxValue;
        Console.WriteLine($"int: Maximum value is {intMaxValue}, allowed value types are whole numbers only");

        // uint
        uint uintMaxValue = uint.MaxValue;
        Console.WriteLine($"uint: Maximum value is {uintMaxValue}, allowed value types are whole numbers only");

        // long
        long longMaxValue = long.MaxValue;
        Console.WriteLine($"long: Maximum value is {longMaxValue}, allowed value types are whole numbers only");

        // decimal
        decimal decimalMaxValue = decimal.MaxValue;
        Console.WriteLine($"decimal: Maximum value is {decimalMaxValue}, allowed value types are decimal numbers with high precision");

        // float
        float floatMaxValue = float.MaxValue;
        Console.WriteLine($"float: Maximum value is {floatMaxValue}, allowed value types are single-precision floating-point numbers");

        // double
        double doubleMaxValue = double.MaxValue;
        Console.WriteLine($"double: Maximum value is {doubleMaxValue}, allowed value types are double-precision floating-point numbers");

        // Half
        Half halfMaxValue = Half.MaxValue;
        Console.WriteLine($"Half: Maximum value is {halfMaxValue}, allowed value types are 16-bit floating-point numbers");

        // Complex
        Complex complexMaxValue = new Complex(double.MaxValue, double.MaxValue);
        Console.WriteLine($"Complex: Maximum value for both the real and imaginary components is {complexMaxValue}, allowed value types are complex numbers");

        // Random
        Random random = new Random();
        int randomIntMaxValue = int.MaxValue;
        Console.WriteLine($"Random int: Maximum value is {randomIntMaxValue}, allowed value types are whole numbers only");
    }
}