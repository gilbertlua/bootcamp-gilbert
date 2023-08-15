using FooBarLibrary;
class Program{
	static void Main(){
		FooBar newFooBar = new FooBar();
		newFooBar.AddRules(1,"foo");
		newFooBar.AddRules(2,"bar");
		
		// Console.WriteLine(newFooBar._dict(1));
	}
	
	public static void Testing()
	{
		int limit = 15;
		FooBar newFooBar = new FooBar(); 		
		for(int i=1;i<=limit;i++)
		{
			newFooBar.SetNumParameter(i);
			newFooBar.GenFoobar();
			string result = newFooBar.GetStrOutput();
			Console.WriteLine(result);
		}
	} 
}

