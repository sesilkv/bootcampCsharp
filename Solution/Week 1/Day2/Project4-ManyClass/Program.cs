using CarLibrary;

class Program
{
	static void Main()
	{
		Engine combustionEngine = new();
		combustionEngine.engineType = "Combustion";
		Engine kayuhEngine = new();
		Engine dieselEngine = new();
		
		Lamp philips = new("philips");
		Lamp petromak = new("petromak");
		
		Tire woodenTire = new();
		Tire rubberTire = new();
		Tire offRoad = new();
		woodenTire.tireSize = 5;
		woodenTire.tireType = "Wooden";
		
		Car sirionCar = new();
		sirionCar.engine = combustionEngine;
		sirionCar.lamp = petromak;
		sirionCar.tire = offRoad;
		
		Car teslaCar = new();
		teslaCar.engine = kayuhEngine;
		teslaCar.lamp = philips;
		teslaCar.tire = woodenTire;
		
		sirionCar.EngineStart();
		teslaCar.LampCheck();
		teslaCar.TireCheck();
	}
}