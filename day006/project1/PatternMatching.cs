namespace Program;

class PatternMatching
{
	public string theString;
	public PatternMatching(string theString)
	{
		this.theString = theString;
	}	
	public void Test()
	{
		if(theString is not null)
		{
			Console.WriteLine("`theString` is not null");	
		}
		if(theString is string strx)
		{
			Console.WriteLine("`theString` value is : "+strx);
		}
	}
}