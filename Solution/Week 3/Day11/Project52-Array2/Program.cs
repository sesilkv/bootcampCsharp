namespace ArrayDemo
{
	class Program
	{
		static void Main()
		{
			Employee emp1 = new Employee("John",5);
			Employee emp2 = new Employee("Zack",2);
			Employee emp3 = new Employee("Dean",4);
			Employee emp4 = new Employee("Amber",1);

			Employee[] Employees = { emp1, emp2, emp3, emp4 };
			Employee[] Employees2 = new Employee[4];
			Employee[] Employees3 = new[] { emp1, emp2, emp3, emp4 };
			
			Employees2[0] = emp1;
			Employees2[1] = emp2;
			Employees2[2] = emp3;
			Employees2[3] = emp4;

			Console.WriteLine($"1 Employee = {Employees[0].Name}");
			Console.WriteLine($"2 Employee = {Employees[1].Name}");
			Console.WriteLine($"3 Employee = {Employees[2].Name}");
			Console.WriteLine($"4 Employee = {Employees[3].Name}");

			for (int i = 0; i <= Employees.Length - 1; i++)
			{
				Console.WriteLine($"Employee[{i}] = {Employees[i].Name}");
			}

			foreach (Employee employee in Employees)
			{
				Console.WriteLine($"{employee.Name}");
			}
				
			Array.Sort(Employees, (x, y) => x.Name.CompareTo(y.Name));
			
			foreach (var employee in Employees)
			{
				Console.WriteLine($"{employee.ID} : {employee.Name}");
			}
		}
		

	}
	class Employee
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public Employee(string name, int id)
		{
			Name = name;
			ID = id;
		}
	}
}