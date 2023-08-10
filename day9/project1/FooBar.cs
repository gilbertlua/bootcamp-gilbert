namespace FooBarLibrary;
class FooBar{
	private int _numParameter;
	private string? _strOutput;
	
	
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