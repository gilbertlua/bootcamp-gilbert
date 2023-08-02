using AnimalsLibrary;
class Program
{
	public static void Main()
	{
		var animals = new Animals();
		var cat = new Cat();
		var dog = new Dog();
		var ant = new Ant();
		cat.MakeSound();
		dog.MakeSound();
		ant.MakeSound();
		
		animals.Eat();
		animals.Eat("wiskas");
		animals.Eat("wiskas","water");
	}
}