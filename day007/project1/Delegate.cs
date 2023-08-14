namespace Program;

public delegate void SimpleDelegate();
class Delegate
{
	public void test()
	{
		SimpleDelegate testDelegate = SayHello;
		testDelegate+=SayHi;
		testDelegate();
	}
	public void SayHello()
	{
		Console.WriteLine("Say Hello");
	}	
	public void SayHi()
	{
		Console.WriteLine("Say Hi");
	}
}