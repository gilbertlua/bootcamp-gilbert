namespace CarLibrary;

class Car
{
	public string? brand;
	public int door;
	public Engine engine;
	public Tire tire;
}

class Engine
{
	public string? engineType;
	public void RunEngine()
	{
		Console.WriteLine($"Engine Run\n Engine type : {engineType}");
	}
} 
class Tire
{
	public int tireSize;
	public void startTire()
	{
		Console.WriteLine($"size is {tireSize}");
	}
}