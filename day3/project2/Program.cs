using StudentsLibrary;
class Program
{
	public static void Main()
	{
		// var student = new Students("SMA N 1 SALATIGA");
		SetAndiProfile();
		SetAndoProfile();
		SetRendiProfile();
		
		var detail = new Students();
		detail.SchoolDetails("Jl Soekarno Hatta");
		detail.SchoolDetails("Acreditations : A ", " 2017-2023");
		Console.WriteLine("\n\n");  
	}
	public static void SetAndiProfile()
	{
		  var student = new Andi();
		  student.studentGender = "Male";
		  student.studentName = "Andi";
		  student.studentNum = "6100";
		  student.SetStudentDate("24/09/2004");
		  string? date = student.GetStudentDate(); 
		  DisplayAllProfiles(student.studentName,student.studentGender,student.studentNum,date);
		  student.StudentPosition();
		  Console.WriteLine("\n\n");
	}
	public static void SetAndoProfile()
	{
		  var student = new Ando();
		  student.studentGender = "Male";
		  student.studentName = "Ando";
		  student.studentNum = "6101";
		  student.SetStudentDate("2/10/2001");
		  string? date = student.GetStudentDate(); 
		  DisplayAllProfiles(student.studentName,student.studentGender,student.studentNum,date);
		  student.StudentPosition();
		  Console.WriteLine("\n\n");
	}
	public static void SetRendiProfile()
	{
		  var student = new Rendi();
		  student.studentGender = "Male";
		  student.studentName = "Rendi";
		  student.studentNum = "6102";
		  student.SetStudentDate("5/3/2002");
		  string? date = student.GetStudentDate(); 
		  DisplayAllProfiles(student.studentName,student.studentGender,student.studentNum,date);
		  student.StudentPosition();
		  Console.WriteLine("\n\n");
	}
	public static void DisplayAllProfiles(string? name,string? gender,string num, string? date )
	{	
		Console.WriteLine("---------------------------------");	
		Console.WriteLine($"{name} Profile");
		Console.WriteLine("---------------------------------");
		Console.WriteLine($"Gender\t\t: {gender}");
		Console.WriteLine($"Student Number\t: {num}");
		Console.WriteLine($"Date\t\t: {date}");  
		Console.WriteLine("---------------------------------");
		
		// display overloading
		
	}
	
}