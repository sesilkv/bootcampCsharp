public class RecursiveClass {
	public RecursiveClass() {
		RecursiveMethod();
	}

	public void RecursiveMethod() {
		RecursiveMethod();
	}
}

class Program {
	static void Main() {
		try {
			RecursiveClass rc = new RecursiveClass();
		}
		catch (Exception ex) {
			Console.WriteLine("StackOverflowException: " + ex.Message);
		}
		Console.WriteLine("RecursiveClass created");
	}
}