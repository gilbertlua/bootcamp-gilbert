namespace Program;
class UpcastDowncast
{
	public int a;
	public double double_test; 
	public UpcastDowncast(int a, double b)
	{
		this.a = a;
		this.double_test = b;
	}
	public void Down()
	{
		double b = a;
		Console.WriteLine($"{b}");
	}
	public void Up()
	{
		int b = (int)double_test;
		Console.WriteLine($"{b}");
	}
	public void Obj()
	{
		object obj = double_test;
		int x = (int)(double)obj;
		Console.WriteLine("Value inside object is : "+x);
	}
	
}