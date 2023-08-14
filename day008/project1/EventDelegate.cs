public class Publisher{
	public event EventHandler<string[]> myEvent;
	public string name = "publisher";
	public void RunEvent(string[] str){
		myEvent.Invoke(this,str);
	}
}

public class Subscriber{
	private string _thename;
	public void Notification(object sender , string[] e){
		//string _name="123"; 	
		
		Console.Write("The Publisher is ");
		_thename = ((Publisher)sender).name;
		Console.WriteLine(_thename);
		Console.WriteLine("The message inside e is :");
		int i = 0;
		foreach(string x in e){
			i++;
			string str = x; 
			Console.WriteLine($"inside e [{i}] is : {str}");
		}
	}
}

class Program{
	
	static void Main(){
		Subscriber sub1 = new();
		Publisher publisher = new();
		string[] _str = {"abc","cde","efg"};
		publisher.myEvent+=sub1.Notification;
		publisher.RunEvent(_str);
		
	}
}
