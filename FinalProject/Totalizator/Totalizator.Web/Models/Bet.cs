using System;

namespace Totalizator.Web.Models
{
	public class Bet
	{
		public int Id { get; set; }
		public DateTime RegistrationDate { get; set; }
		public int SportEventId { get; set; }
		public EventResult EventResult { get; set; }
		public User User { get; set; }
	}
}