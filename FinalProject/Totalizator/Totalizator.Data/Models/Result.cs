﻿namespace Totalizator.Data.Models
{
	public class Result
	{
		public int Id { get; set; }
		public ResultType ResultType { get; set; }
		public double Coefficient { get; set; }
		public int SportEventId { get; set; }
	}
}