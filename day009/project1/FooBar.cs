using System.Collections.Generic;
using System.Text;
namespace FooBarLibrary;
class FooBar{
	private string? _result = null;
	Dictionary<int,string>? _dict = new Dictionary<int, string>();
	StringBuilder _resultRange = new StringBuilder();
	StringBuilder _resultRules = new StringBuilder();
	
	
	// Add rules
	public bool AddRules(int key, string? output){
			if(output is not null){
				try{
					_dict?.Add(key,output);
				}
				catch(Exception e){
					throw new ArgumentException(e.ToString());
				}
				return true;
			}
			return false;
	}
	// Check rules
	public string CheckRules(){
		if(_dict is not null){
			foreach(var x in _dict){
				_resultRules.Append(x+"\n");
			}
			return _resultRules.ToString();
		}
		return "";
	}
	// Generate single check
	public string SingleCheck(int param){
		if(_dict is not null){
			foreach(var kvp in _dict){
				if((param%kvp.Key) == 0){
					_result += kvp.Value;	
				}
			}	
			if(_result is null){
				return param.ToString();
			}
		}
		if(_result is not null){
			return _result;
		}
		return "";
	}
	// generate Ranges chace
	public string? RangesCheck(int limit){		
		int i;
		for(i=1;i<=limit;i++){
			this._result = null;
			_resultRange.Append(SingleCheck(i)+" ") ;
		}
		if(_resultRange is not null){
			return _resultRange.ToString();
		}
		return "";
	}
}