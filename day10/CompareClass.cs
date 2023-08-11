class AsusRog{
	private int _ramSize;
	
	public AsusRog(int ramSize){
		this._ramSize = ramSize;
	}
	public bool isStrong(object x){
		if(x == null){
			return false;
		}
		else if((((AsusRog)x)._ramSize < this._ramSize)&&(this.GetType() == x.GetType())){
			return true;
		}
		return false;
	}
}

class Program{
	static void Main(){		
		AsusRog asusRog1 = new(19);
		AsusRog asusRog2 = new(12);
		object comTest = asusRog2;
		bool isTrue = asusRog1.isStrong(comTest);
		
		if(isTrue){
			Console.WriteLine("Asus ROG 1 is strong more than ROG 2");
		}
		else{
			Console.WriteLine("Asus ROG 2 is strong more than ROG 1");
		}
	}
}
