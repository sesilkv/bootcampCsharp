using CarEngine;

public class Program {
	static void Main() {
		CombustionEngine engineComb = new();
		DieselEngine engineDiesel = new();
		ElectricEngine engineElectric = new();
		
		Car car = new Car(engineElectric); //
		car.Start();
		
		Car car2 = new Car(engineComb); //
        car2.Start();
	}
}