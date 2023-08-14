using System.Collections.Generic;
namespace FooBarLibrary;
class FooBar{
	private int _numParameter;
	private string? _strOutput;
	private  static string[] modelString = new string[10]; 
	List<String> modelStrings = new List<String>();
	
	
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
	public void AddModels(int numParameter,string? stringOut){
		
		if(stringOut is not null){
			modelStrings.Insert(numParameter,stringOut);
		}
		
	}
	public  void CheckModuls(){
		int i=0;
		foreach(string x in modelStrings){			
			Console.WriteLine(i+": "+x);
			i++;
		}
	}
}