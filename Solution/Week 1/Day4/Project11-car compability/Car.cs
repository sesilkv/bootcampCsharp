namespace CarEngine;

public interface IEngine {
	void Run();
}
public class CombustionEngine : IEngine {
	public void Run() {
		Console.WriteLine("Combustion engine run");
	}
}
public class ElectricEngine : IEngine {
	public void Run() {
		Console.WriteLine("Electric engine run");
	}
}
public class DieselEngine : IEngine {
	public void Run() {
		Console.WriteLine("Diesel engine run");
	}
}
public class HydroEngine : IEngine{
	public void Run() {
		Console.WriteLine("Hydro engine run");
	}
}
public class Car {
	public IEngine engine;
	
	public Car(IEngine engine) {
		this.engine = engine;
	}
	
	public void Start() {
		engine.Run();
	}
}