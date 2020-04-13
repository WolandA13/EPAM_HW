using System;

namespace Totalizator.Data.Models
{
	public class Bet
	{
		public int Id { get; set; }
		public DateTime RegistrationDate { get; set; }
		public int SportEventId { get; set; }
		public int UserId { get; set; }
	}
}
