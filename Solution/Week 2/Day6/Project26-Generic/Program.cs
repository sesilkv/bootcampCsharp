class Program 
{
	static void Main()
	{
		ToyBox<int> intGenericClass = new ToyBox<int>(10);
		int result = intGenericClass.ToyBoxMethod(5);
		Console.WriteLine($"Nilai Mainan: {result}");

		ToyBox<string> stringGenericClass = new ToyBox<string>("Hello");
		stringGenericClass.ToyBoxMethod("World");
		Console.WriteLine($"Nilai Mainan: {result}");
	}
}

public class ToyBox<T> // T = type data
{
	private T Toy;

	public ToyBox(T value)
	{
		Toy = value;
	}

	public T ToyBoxMethod(T parameter)
	{
		Console.WriteLine($"Mainan : {Toy}");
		Console.WriteLine($"Parameter : {parameter}");

		return parameter;
	}
}