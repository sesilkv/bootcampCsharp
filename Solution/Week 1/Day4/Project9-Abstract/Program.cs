using Abstract;

public class Program
{
	static void Main() {
		Child child = new();
		ParentAbstract parent = child;
		ParentAbstract.Add(5, 6);
		parent.GetTotal();
		child.Scan();
	}
}