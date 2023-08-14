public interface IPrint {
	void Print();
}
public interface IFax {
	void Fax();
}
public interface IScan {
	void Scan();
}
public abstract class ParentAbstract {
	public int x;
	public int y;
	
	public void Add() { //non abstract
		Console.WriteLine(x+y);
	}
	public abstract int GetTotal();
}

public class Child : ParentAbstract, IScan, IPrint, IFax {
	public override int GetTotal() {
		return x+y;
	}
	public void Print()
	{
		Console.WriteLine("Fax");
	}
	public void Fax()
	{
		Console.WriteLine("Fax");
	}
	public void Scan() {
		Console.WriteLine("Scan");
	}
}

class Program
{
	static void Main() {
		Child child = new Child();
		ParentAbstract parent = child;
		parent.Add();
		parent.GetTotal();
	}
	
}
