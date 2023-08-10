class Calculator{

	private int _number;
	
	public int getResult(){
		return _number;
	}
	public Calculator(int number){
		this._number = number;
	}
	public static Calculator operator +(Calculator calc1, Calculator calc2){
		int result = calc1._number + calc2._number;
		return new Calculator(result);
	}
	
}

class Program{
	public static void Main(){
		Calculator calc1 = new(1);
		Calculator calc2 = new(5);
		Calculator calc3 = new(8);
		Calculator result = calc1+calc2+calc3;
		Console.WriteLine($"result is :{result.getResult()}");
	}
}