using System;

namespace Totalizator.Web.Models
{
	public class SportEvent
	{
		public int Id { get; set; }
		public DateTime EventDate { get; set; }
		public Team[] Teams { get; set; }
		public string Sport { get; set; }
	}
}