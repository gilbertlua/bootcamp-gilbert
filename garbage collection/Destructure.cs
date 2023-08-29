class DestructureClass{
	StringBuilder sb = new StringBuilder();
	private String textString= "";
	public DestructureClass(string text){
		Console.WriteLine("Text output :"+ text);
	}
	public bool AddStringBuilder(string text){		
		if(text is not null){
			sb.Append(text);
			return true;
		}
		return false;
	}
	public bool AddString(string text){
		if(text is not null){
			text += text;
			return true;
		}
		return false;
	}
	public bool RemoveAll(){
		if(this is not null){
			this.sb = null;
			this.textString = null;
		}
		return true;
	}
	~DestructureClass(){
		string type = GetType().Name; 
		Console.WriteLine($"success distroy {type}");
	}
}

class Program{
	static void Main(){
		DestructureClass d = new DestructureClass("abc");
		d.AddString("123");
		d.AddString("321");
		d.AddString("132");
		
		for(int i=0; i<=10000000 ; i++){
			d.AddString($"{i}");
		}
		d.AddStringBuilder("text");
		//d.RemoveAll();
		
		
		DestructureClass x = new DestructureClass("cba");
		//x.AddString("123");
		//x.AddStringBuilder("text");
		////x.RemoveAll();
		
	}
}