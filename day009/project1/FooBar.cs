using System.Collections.Generic;
namespace FooBarLibrary;
class FooBar{
	private int _numParameter;
	private string? _strOutput; 
	Dictionary<int,string>? _dict = new Dictionary<int, string>();
	
	
	// Add rules

	public bool AddRules(int key, string? output){
		if(output is not null){
			_dict?.TryAdd(key,output);
			return true;
		}
		return false;
	}
	public void SetNumParameter(int value)
	{
		this._numParameter = value;
	}
	public string GetStrOutput()
	{
		if(_strOutput is not null)
		{
			return _strOutput;
		}
		return " ";
	}
	public void GenFoobar()
	{
		string str = StringOutput(_numParameter);
		this._strOutput = str; 
	}
	public string StringOutput(int i){
		if (i % 3 == 0 && i % 5 == 0)
		{
			return "foobar";
		}
		else if (i % 3 == 0)
		{
			return "foo";
		}
		else if (i % 5 == 0)
		{
			return "bar";
		}
		else
		{
			return i.ToString();
		}
	}
}