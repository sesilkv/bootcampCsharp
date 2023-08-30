class Program
{
	static void Main(string[] args)
	{
		MyClass obj = new();
	}
}

class MyClass 
{
	MyOtherClass obj1 = new();
	~MyClass()
	{
		Console.WriteLine("MyClass destructor called");
	}
}

class MyOtherClass
{
	~MyOtherClass()
	{
		Console.WriteLine("MyOtherClass destructor called");
	}
}