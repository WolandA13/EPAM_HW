using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.DTO
{
	public class PersonalDataDTO
	{
		public PersonalData PersonalData { get; set; }
		public IEnumerable<ContactInformation> ContactInformationList { get; set; }
	}
}
