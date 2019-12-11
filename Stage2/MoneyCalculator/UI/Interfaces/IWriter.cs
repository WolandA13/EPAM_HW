namespace UI.Interfaces
{
	public interface IWriter<T>
	{
		public void WriteLine(string data = "");

		public void Write(string data);

		public void Write(params T[] data);
	}
}
