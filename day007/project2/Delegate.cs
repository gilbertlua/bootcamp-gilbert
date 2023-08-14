public delegate void Delegate();

class TestDelegate{
	public void runTesting(){
		Delegate turnOnPC = TurnOnPc;
		Delegate turnOffPC = TurnOffPc;
		
		Console.WriteLine("input string (TON) to turn on PC (TOFF) to turn off PC : ");
		string param = "";
		
		while(param != "x"){
			param = Console.ReadLine();
			switch(param){
			
			case "TON":
						Performaction(turnOnPC);
						break;
			case "TOFF":
						Performaction(turnOffPC);
						break;
			default:
						Console.WriteLine("wrong input");
						break;
			}
		}
		
	}
	public void TurnOnPc(){
		Console.WriteLine("Turn on the PC");
	}
	public void TurnOffPc(){
		Console.WriteLine("Turn off the PC");
	}
	public void Performaction(Delegate a){
		a();
	}
	
}

static void Main(){
	TestDelegate test = new();
	test.runTesting();
}