<Query Kind="Program" />

abstract class Rasberry{
	private string _ramSize;
	
	public void SetRamSize(string ramSize){
		this._ramSize = ramSize;
	}
	public string GetRamSize(){
		return this._ramSize;
	}
	public abstract string CheckSpec();
}
class RasberryZero:Rasberry{
	public override string CheckSpec(){
		return GetRamSize();
	}
}
void Main()
{
	
}

