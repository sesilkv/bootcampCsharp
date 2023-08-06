namespace HumanLibrary;

class Human 
{
	private string? _name;
	private int _age;
	private int _salary;
	
	//CONSTRUCTOR
	public Human(string name, int age, int salary)
	{
		_name = name;
		_age = age;
		_salary = salary;	
	}
	
	public int GetAge()
	{
		return _age;
	}
	
	public int SetAge(int age)
	{
		_age = age;
		return _age;
	}
}