class Program
{
	public static void Main()
	{
		Cat anggora = new Cat();//wujud asli blue print
		anggora.MakeSound();
		anggora.name = "alex";
		anggora.age = 12;
		anggora.isMale =true;
		anggora.isOwner =true;
		Console.WriteLine(anggora.name);
		Console.WriteLine(anggora.age);
		anggora.Eat();
		
	}
}
