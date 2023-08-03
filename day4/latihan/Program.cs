using IncludeInterfaceLib;
using PropertiesLibrary;
class Program
{
	public static void Main()
	{	
		// ShowInterface show = new ShowInterface();
		// show.Print();
		// show.Scan();
		// show.Fax();
		
		ShowInterface print = new();
		IFax newScan = print;
		newScan.Fax();
		
		PropertyLearn prop = new();
		prop.name = "gilbert";
		string newName = prop.name;
		
		Console.WriteLine(newName); 
	}
}
