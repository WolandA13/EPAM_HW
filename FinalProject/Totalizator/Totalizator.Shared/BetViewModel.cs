using System;

namespace Totalizator.Shared
{
	public class BetViewModel
	{
		public int Id { get; set; }
		public DateTime RegistrationDate { get; set; }
		public int SportEventId { get; set; }
		public int UserId { get; set; }
	}
}
