using AnimalLibrary;


class Program
{
	public static void Main()
	{
		Bird _bird = new Bird();
		int birdAge = _bird.age = 12;
		string? birdName =  _bird.name = "Tino";
		
		Console.WriteLine($"Bird Name\t:{birdName}");
		Console.WriteLine($"Bird Age\t:{birdAge}");
		
		// _bird.Sleep();
		// _bird.Eat();
		// _bird.MakeSound();
		// _bird.Fly();
	}
}