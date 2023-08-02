namespace StudentsLibrary;

class Students
{
	public string? studentName;
	public string? studentNum;
	public string? studentGender;
	private string? _dateStudent;
	private int _studentTotal=0;
	
	// constructor
	public Students()
	{
		_studentTotal++;
	}
	public int getStudentTotal()
	{
		return _studentTotal;
	}
	
	public void SetStudentDate(string? date)
	{
		this._dateStudent = date;
	}
	public string GetStudentDate()
	{
		if(_dateStudent is null)
		{
			return "";
		}
		else
		{
			return _dateStudent;	
		}
		
	}
	
	// override
	public virtual void  StudentPosition()
	{
		Console.WriteLine("active student");
	}
	
	// overloading
	public void SchoolDetails(string? address)
	{
		Console.WriteLine($"{address}");
	}
	public void SchoolDetails(string? accreditation, string? period)
	{
		Console.WriteLine($"{accreditation} period {period}");
	}
	
	
}
class Andi:Students
{
	public override void  StudentPosition()
	{
		Console.WriteLine("active student, Class Chairman");
	}
	
}
class Ando:Students
{
	public override void  StudentPosition()
	{
		Console.WriteLine("active student, secretary in class");
	}
}
class Rendi:Students
{
		
}