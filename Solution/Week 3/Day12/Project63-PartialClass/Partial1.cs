namespace Test;

public partial class Employee
{
	private string _name;
	private int _salary;
	private int _tunjangan;

	public Employee(string name, int salary, int tunjangan)
	{
		_name = name;
		_salary = salary;
		_tunjangan = tunjangan;
	}

	public string GetName()
	{
		return _name;
	}

	public int GetSalary()
	{
		return _salary;
	}

	public int GetTunjangan()
	{
		return _tunjangan;
	}
}