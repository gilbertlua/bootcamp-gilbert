namespace AnimalsLibrary;

class Animals
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Sounding");
	}
	
	// Override Test
	public void Eat()
	{
		Console.WriteLine("Im eat");
	}
	public void Eat(string food)
	{
		Console.WriteLine("Im eat {0}",food);
	}
	public void Eat(string food, string drink)
	{
		Console.WriteLine("Im eat {0} and drink {1}",food,drink);
	}
}
class Cat:Animals
{
	public override void MakeSound()
	{
		Console.WriteLine("Meaw");
	}
}
class Dog:Animals
{
	public override void MakeSound()
	{
		Console.WriteLine("Guk Guk");
	}
}
class Ant:Animals
{
   
}