namespace AnimalLibrary;

class Animal
{	
	public string? name;
	public int age;
	
	public Animal() {
        Console.WriteLine("Parent Animal created");
    }
	public void  Sleep()
	{
		Console.WriteLine("Sleep");
	}	
	public void MakeSound()
	{
		Console.WriteLine("MakeSound");
	}
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
}

class Bird:Animal
{
	public Bird() {
        Console.WriteLine("Child Bird Created");
    }
	public void Fly()
	{
		Console.WriteLine("Bird Fly");
	}
}
class Turtle:Animal
{
	public void Swim()
	{
		Console.WriteLine("Turtle Swim");
	}
}
class Cat:Animal
{
	public void Scratch()
	{
		Console.WriteLine("Cat Scratch");
	}
}