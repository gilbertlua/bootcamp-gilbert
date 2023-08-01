using CarLibrary;
class Program
{
	public static void Main()
	{	
		Car car = new Car();
		car.brand = "Toyota";
		car.door = 4;
		
		Engine electric = new Engine();
		Tire tireSize = new Tire();
		
		car.engine = electric;
		car.tire = tireSize;
		car.engine.engineType = "4 tak";
		car.tire.tireSize = 12;
		car.engine.RunEngine();
		car.tire.startTire();		
	}
}