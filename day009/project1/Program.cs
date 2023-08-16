using FooBarLibrary;
class Program{
	static void Main(){
		FooBar newFooBar = new FooBar();
		newFooBar.AddRules(3,"foo");
		newFooBar.AddRules(5,"bar");
		newFooBar.AddRules(7,"fizz");
		newFooBar.AddRules(9,"fuzz");
		newFooBar.AddRules(9,"fazz");

		// Console.WriteLine(newFooBar.RangesCheck(15));
		Console.WriteLine(newFooBar.RangesCheck(15));
		// string result = newFooBar.CheckRules();
		// Console.WriteLine(result);

	}
}

