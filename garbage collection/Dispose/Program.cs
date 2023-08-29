using System;
using System.IO;
using System.Text;

class Program
{
	static void Main()
	{
		string filePath = "textfile.txt";

		try
		{
			using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
				{
					string? line;
					while ((line = reader.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}					
				}
			}
		}
		catch (IOException e)
		{
			Console.WriteLine("Error while open file " + e.Message);
		}
	}
}