namespace Totalizator.Shared
{
	public class ResultViewModel
	{
		public int Id { get; set; }
		public ResultTypeViewModel ResultType { get; set; }
		public double Coefficient { get; set; }
		public int SportEventId { get; set; }
	}
}
