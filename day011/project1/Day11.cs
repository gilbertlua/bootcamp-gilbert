void Main()
{
	List<string> list = new();
	list.Add("ha");
	list.Add("hi");
	list.Add("hu");
	list.Add("hes");
	foreach(string x in list){
		Console.WriteLine($"value :{x}");
	}
	Console.WriteLine();
	Console.ReadLine();
	
	Dictionary<int,string> dict = new();
	dict.Add(1,"tomi");
	dict.Add(2,"budi");
	dict.Add(3,"timo");
	dict.Add(3,"timo");
	
	foreach(var x in dict){
		Console.WriteLine(x);
	}
	
	
	ArrayList arrayList = new();
	
	//add string 
	arrayList.Add("string 1 added");
	arrayList.Add("string 2 added");
	
	//add interger
	arrayList.Add(12);
	arrayList.Add(4);
	
	//add double
	arrayList.Add(12.5f);
	arrayList.Add(1.12f);
	
	int i = 0;
	
	foreach(var x in arrayList){
		if(x.GetType() == typeof(string)){
			Console.WriteLine($"Index of {i} the type : {typeof(string)} and value : {x}");
		}
		if(x.GetType() == typeof(int)){
			Console.WriteLine($"Index of {i} the type : {typeof(int)} and value : {x}");
		}
		if(x.GetType() == typeof(float)){
			Console.WriteLine($"Index of {i} the type : {typeof(float)} and value : {x}");
		}
		i++;
	}
	
}

