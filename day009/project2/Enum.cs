public enum FaceShape{
	Oval,
	Square,
	Round,
	Chuby,
	Chiseled
}

class FaceShapeCheck{
	private int _shapeParameter;
	
	//set parameter
	public void SetShapeParameter(int value){
		this._shapeParameter = value;
	}
	public string GetResult(){
		string result = DetShapeFace();
		return result; 
	}
	public string DetShapeFace(){
		if(_shapeParameter == 1){
			return (FaceShape.Oval).ToString();
		}
		else if(_shapeParameter == 2){
			return (FaceShape.Square).ToString();
		}
		else if(_shapeParameter == 3){
			return (FaceShape.Round).ToString();
		}
		else if(_shapeParameter == 4){
			return (FaceShape.Chuby).ToString();
		}
		else if(_shapeParameter == 4){
			return (FaceShape.Chiseled).ToString();
		}
		
		else{
			return "";
		}
	}
}

public void Main(){
	FaceShapeCheck test = new();
	test.SetShapeParameter(5);
	string str = test.GetResult();
	Console.WriteLine(str);
}