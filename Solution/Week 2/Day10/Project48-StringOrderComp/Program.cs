class Program
{
    static void Main()
    {
        // Ordinal Comparison
        string string1 = "Hello";
        string string2 = "hello";
        int result = String.Compare(string1, string2, StringComparison.Ordinal);
        Console.WriteLine(result);
        if (result == 0)
        {
            Console.WriteLine("The strings are equal.");
        }
        else if (result < 0)
        {
            Console.WriteLine("string1 comes before string2.");
        }
        else
        {
            Console.WriteLine("string2 comes before string1.");
        }

        // Ordinal Ignore Case Comparison
        string string5 = "hello";
        string string6 = "HELLO";

        result = String.Compare(string5, string6, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(result);
        if (result == 0)
        {
            Console.WriteLine("The strings are equal.");
        }
        else if (result < 0)
        {
            Console.WriteLine("string5 comes before string6.");
        }
        else
        {
            Console.WriteLine("string6 comes before string5.");
        }

    }
}