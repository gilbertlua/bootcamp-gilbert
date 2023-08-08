namespace Program;

class Program
{
	static void Main()
	{
		TestDelegate();	
	}
	static void TestDelegate()
	{
		Delegate runDelegate = new();
		runDelegate.test(); 
	}
}