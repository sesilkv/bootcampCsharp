namespace CarLibrary;

public class Car 
{
	public Engine engine;
	public Tire tire;
	public Lamp lamp;
	
	public void EngineStart()
	{
		engine.EngineRun();
		engine.EngineOilCheck();
		engine.EngineStop();
	}
	public void LampCheck()
	{
		lamp.TurnOn();
	}
	public void TireCheck()
	{
		tire.CheckTireSize();
		tire.CheckTireType();
	}
}