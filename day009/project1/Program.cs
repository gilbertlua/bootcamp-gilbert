using FooBarLibrary;
class Program{
	static void Main(){
		Testing();
	}
	
	public static void Testing()
	{
<<<<<<< Updated upstream
		
		FooBar newFooBar = new FooBar();
		newFooBar.AddModels(1,"foo");
		// newFooBar.CheckModuls();
=======
		int limit = 15;
		FooBar newFooBar = new FooBar(); 		
		for(int i=1;i<=limit;i++)
		{
			newFooBar.SetNumParameter(i);
			newFooBar.GenFoobar();
			string result = newFooBar.GetStrOutput();
			Console.WriteLine(result);
		}
>>>>>>> Stashed changes
	} 
}

