//Operator Overloading
class Car
{
	public string carBrand;
	public Car(string carBrand)
	{
		this.carBrand = carBrand;
	}
	public static Car operator +(Car car1, Car car2)
	{
		string result = car1.carBrand + car2.carBrand;
		//manggil class car
		return new Car(result);
	}
}

class Program
{
	static void Main()
	{
		Car car1 = new Car("Budi");
		Car car2 = new Car("SMK");
		Car car3 = new Car("Ucok");
		Car car4 = new Car("Ucok");
		Car resultCar = car1 + car2 + car3 + car4;
		Console.WriteLine(resultCar.carBrand);
	}
}