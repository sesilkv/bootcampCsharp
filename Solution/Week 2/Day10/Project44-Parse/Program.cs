using System;

class Program
{
    static void Main()
    {
        // Formatting example
        double number = 123456.5678;

        // Two decimal places //1234.56
        Console.WriteLine("Currency format: {0:C2}", number);

        // Thousands separator
        Console.WriteLine("Number format with separator: {0:N}", number);

        // Parsing example
        string input = "1234.56";
        double result = double.Parse(input);
    }
}