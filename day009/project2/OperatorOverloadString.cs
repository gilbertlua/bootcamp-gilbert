class Calculator{

	private string _str;
	
	public string getResult(){
		return _str;
	}
	public Calculator(string str){
		this._str = str;
	}
	public static Calculator operator +(Calculator calc1, Calculator calc2){
		string result = calc1._str + calc2._str;
		return new Calculator(result);
	}
	
}

class Program{
	public static void Main(){
		Calculator calc1 = new("how ");
		Calculator calc2 = new("you ");
		Calculator calc3 = new("do ");
		Calculator result = calc1+calc2+calc3;
		Console.WriteLine($"result is :{result.getResult()}");
	}
}