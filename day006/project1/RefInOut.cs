namespace Program;
class RefInOut
{
	public void InTest(in int x)
	{
		Console.WriteLine("x value IN: "+x*2);
	}
	public void OutTest(out int y)
	{
		y=300;
		Console.WriteLine("x value OUT: "+y);
	}
	public void RefTest(ref int z)
	{
		z+=100;
		Console.WriteLine("x value REF: "+z);
	}
}