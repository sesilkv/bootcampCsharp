class Parent 
{
	public void ParentMethod()
	{
		Console.WriteLine("Parent");
	}
}

class Child:Parent 
{
	public void ChildMethod()
	{
		Console.WriteLine("Child");
	}
}

class Program 
{
	static void Main()
	{
		// Parent parent = new(); //AB
		//parent dipaksa dimasukkan ke child
		// Child child = (Child)parent; //ABCD <- AB
		// parent.ParentMethod();
		// child.ChildMethod();
		
		//EXPLICIT CASTING tipe data besar ke kecil
		double a = 9.9;
		int b = (int)a;
		Console.WriteLine(b);
	}
}