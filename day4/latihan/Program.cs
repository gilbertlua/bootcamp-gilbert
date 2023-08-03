using IncludeInterfaceLib;
class Program
{
	public static void Main()
	{	
		ShowInterface show = new ShowInterface();
		show.Print();
		show.Scan();
		show.Fax();
	}
}
