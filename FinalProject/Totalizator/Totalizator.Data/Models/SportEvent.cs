using System;

namespace Totalizator.Data.Models
{
	public class SportEvent
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public int SportId { get; set; }
	}
}