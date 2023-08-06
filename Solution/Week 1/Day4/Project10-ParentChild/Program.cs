using ParentChild;

public class Program {
	static void Main() {
        Parent parent = new Parent();
        Child child = new Child();
        
        child.ParentMethod();
        child.ParentMethod2();
        child.ChildMethod();
        
        Parent parent2 = child;
        parent2.ParentMethod();
        parent2.ParentMethod2();
        // parent2.ChildMethod();
	}
}