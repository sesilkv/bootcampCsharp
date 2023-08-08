namespace Namespace;

public static class Program
{
    public static void Main()
    {
        Example<int> example1 = new(10);
        example1.Display(); 

        Example<string> example2 = new("Hello, world!");
        example2.Display();
    }
}

public class Example<T>
{
    private readonly T value;

    public Example(T value)
    {
        this.value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {value}");
    }
}