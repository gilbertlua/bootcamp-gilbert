<Query Kind="Program" />

//Inheritance

class Asus{
	private string _serialNumber;
	private string _lcdSize;
	private string _ramSize;
	
	//get spec
	public string getSerialNumber(){
		return _serialNumber;
	}
	public string getLcsSize(){
		return _lcdSize;
	}
	public string getRamSize(){
		return _ramSize;
	}
	
	//set spec
	public void GetSerialNumber(string value){
		this._serialNumber = value;
	}
	public void GetLcsSize(string value){
		this._lcdSize = value;
	}
	public void GetRamSize(string value){
		this._ramSize = value;
	}
	
	//
	public virtual string Excess(){
		return "Powerfull Speed";
	}
}

class AsusRog:Asus{
	public override string Excess(){
		return "Powerfull Speed and have long time batterai";
	}
}
class AsusRogShark:Asus{
	public override string Excess(){
		return "Powerfull Speed and have long time batterai, have VGA high resolution";
	}
}

void Main()
{
	AsusRogShark newAsus = new();
	newAsus.Excess().Dump();
}
