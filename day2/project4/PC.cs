namespace project4;

class PC
{
	public string? pcType;
	public string? ramSize;
	public Mouse? _mouse;
	public MainBoard? _mainboard;	
	
	public void DispDesc()
	{
		Console.WriteLine("\n----------------------------");	
		Console.WriteLine($"PC Type is\t: {pcType}");
		Console.Write("Mouse Type\t: "); _mouse?.MouseType();
		Console.Write("MainBrd Type\t: "); _mainboard?.MainBoardType();
		Console.WriteLine("----------------------------\n");
	}
}
class Mouse
{
	public string? mouseType;
	public Mouse(string mouseType)
	{
		this.mouseType = mouseType;
	}
	public void MouseType()
	{
		Console.WriteLine(mouseType);
	}
}
class MainBoard
{
	public string? mainoardType;
	public MainBoard(string mainoardType)
	{
		this.mainoardType = mainoardType;
	}
	public void MainBoardType()
	{
		Console.WriteLine(mainoardType);
	}
}

