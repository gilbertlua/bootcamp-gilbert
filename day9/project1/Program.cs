using FooBarLibrary;
class Program{
	static void Main(){
		Testing();
	}
	
	public static void Testing()
	{
		int limit = 15;
		for(int i=1;i<=limit;i++)
		{
			FooBar newFooBar = new FooBar(); 		
			newFooBar.SetNumParameter(i);
			newFooBar.GenFoobar();
			string result = newFooBar.GetStrOutput();
			Console.WriteLine(result);
		}
	} 
}

