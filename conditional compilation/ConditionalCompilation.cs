namespace ConditionalCompilationExample
{
	class ConditionalCompilation
	{
		public static void Release()
		{
			GenerateOddSeries();
		}
		public static void Debug()
		{
			GenerateEvenSeries();
		}
		
		
		public static void GenerateOddSeries()
		{
			int number = 1;
			int count = 5;
			for(int i = 0 ; i < count ; i++)
			{
				Console.Write($"{number} ");
				number += 2;
			}
			Console.WriteLine();
		}
		public static void GenerateEvenSeries()
		{
			int number = 2;
			int count = 20;

			for (int i = 0; i < count; i++)
			{
				Console.Write($"{number} ");
				number += 2;
			}
			Console.WriteLine();
		}
		
	}
}