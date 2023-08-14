class Program
{
	public static void Main()
	{
		Calc add = new Calc();
		int result = add.Add(1,2);
		Console.WriteLine($"{result}");
	}
}

class Calc
{
	public int Add(int x, int y)
	{
		int result = x+y;
		return result;
	}
}