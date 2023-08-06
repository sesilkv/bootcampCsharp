namespace ParentChild;

class Parent {
	public void ParentMethod() {
		Console.WriteLine("parent");
	}
	public void ParentMethod2() {
		Console.WriteLine("Parent2");
	}
}
class Child : Parent
{
	public void ChildMethod() {
		Console.WriteLine("child method");
	}
}