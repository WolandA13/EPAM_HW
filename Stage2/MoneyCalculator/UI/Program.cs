namespace UI
{
	class Program
	{
		static void Main(string[] args)
		{
			UserInterface userInterface = new UserInterface(new ConsoleWriter<double>(), new ConsoleReader());
			userInterface.Start();
		}
	}
}
