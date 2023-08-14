namespace Program;
class Program
{
	static void Main()
	{
		// UpcastDowncastTest();
		// PatternMatchingTest();
		// RefInOutTest();
		ConstReadOnly();
	}
	
	// Upcast & Downcast
	public static void UpcastDowncastTest()
	{
		var test = new UpcastDowncast(1,12f);
		test.Obj();
	}
	// Pattern Matching
	public static void PatternMatchingTest()
	{
		var test = new PatternMatching("hello world");
		test.Test();
	}
	
	// Ref In Out
	public static void RefInOutTest()
	{
		int x = 200;
		var test = new RefInOut();
		Console.WriteLine("IN Test --");
		test.InTest(in x);
		Console.WriteLine("x value now : "+x);
		
		
		int y;
		Console.WriteLine("OUT Test --");
		test.OutTest(out y);
		Console.WriteLine("x value now : "+y);
		
		int z=400;
		Console.WriteLine("REF Test --");
		test.RefTest(ref z);
		Console.WriteLine("x value now : "+z);
	}
	
	// Const Readonly
	public static void ConstReadOnly()
	{
		ConstReadOnly test = new(5);
		Console.WriteLine("width : "+ConstReadOnly.width);
	} 
	
	
}
