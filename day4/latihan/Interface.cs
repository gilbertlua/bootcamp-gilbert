namespace IncludeInterfaceLib;

interface IPrint {
	void Print();
}
interface IFax {
	void Fax();
}
interface IScan {
	void Scan();
}
interface IPrinterMahal:IPrint,IFax,IScan
{
	
}
class ShowInterface:IPrinterMahal
{
	public void Print()
	{
		Console.WriteLine("include print");
	}
	public void Scan()
	{
		Console.WriteLine("include scan");
	}
	public void Fax()
	{
		Console.WriteLine("include Fax");
	}
}