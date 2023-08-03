namespace PropertiesLibrary;

class PropertyLearn
{
	private string _name;
	public string name { 
		get {
			return _name;
		}
		set {
			_name += value;	// _name = _name + value;
		}
	}	
}
