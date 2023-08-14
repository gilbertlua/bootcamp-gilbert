using project4;
class Program
{
	
	public static void Main()
	{
		Mouse asusMouse = new Mouse("Asus Mouse New Gen");
		Mouse hpMouse = new Mouse("HP Mouse Old Gen");
		MainBoard rogMainboard = new MainBoard("ROG 2.1.3");
		MainBoard msiMainboard = new MainBoard("MSI 18.9.9");
		Console.WriteLine("\n\n");
		AsusMerk(asusMouse,rogMainboard);
		HpMerk(hpMouse,msiMainboard);
	}
	public static void AsusMerk(Mouse asusMouse, MainBoard rogMainboard)
	{
		PC asus = new PC();
		asus._mainboard = rogMainboard;
		asus._mouse = asusMouse;
		asus.pcType = "ASUS Laptop";
		asus.ramSize = "12 GB";
		
		Console.Write($"--{asus.pcType}--");
		asus.DispDesc();
	}
	public static void HpMerk(Mouse hpMouse, MainBoard msiMainboard)
	{
		PC asus = new PC();
		asus._mainboard = msiMainboard;
		asus._mouse = hpMouse;
		asus.pcType = "HP Laptop";
		asus.ramSize = "12 GB";
		
		Console.Write($"--{asus.pcType}--");
		asus.DispDesc();
	}
}