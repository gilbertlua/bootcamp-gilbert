using IncludeInterfaceLib;
using PropertiesLibrary;
class Program
{
	public static void Main()
	{	
		ShowInterface print = new();
		IFax newScan = print;
		newScan.Fax();
		
		PropertyLearn prop = new();
		prop.name = "gilbert";
		string newName = prop.name;
		
		Console.WriteLine(newName); 
	}
}
