namespace ConditionalCompilationExample
{
	class Program
	{
		static void Main(string[] args)
		{
			#if (DEBUG)
			ConditionalCompilation.Debug();
			#endif

			#if (RELEASE)
			ConditionalCompilation.Release();
			#endif

			Console.WriteLine("Program has finished.");
			Console.ReadLine();
		}
	}
}
