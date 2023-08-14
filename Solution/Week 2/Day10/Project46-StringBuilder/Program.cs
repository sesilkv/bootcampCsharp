using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        // Append strings to the StringBuilder object
        sb.Append("The quick brown fox ");
        sb.Append("jumps over the lazy dog.");

        // Insert a string at a specific position
        sb.Insert(4, "lazy ");

        // Replace a substring with another string
        sb.Replace("quick", "slow");

        // Remove a substring from the string
        sb.Remove(4, 4);

        // Convert the StringBuilder object to a string
        string result = sb.ToString();

        Console.WriteLine(result);
    }
}