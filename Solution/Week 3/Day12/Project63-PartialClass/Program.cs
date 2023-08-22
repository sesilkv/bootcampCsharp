using Test;

class Program 
{
	static void Main(string[] args)
	{
		Employee employee = new Employee("Sesil", 10000, 2000);
		Console.WriteLine(employee.CheckSalary());
		Console.WriteLine(employee.GetName());
	}
}