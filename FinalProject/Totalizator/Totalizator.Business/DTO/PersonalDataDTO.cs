using System.Collections.Generic;
using Totalizator.Shared.Realization;

namespace Totalizator.Business.DTO
{
	public class PersonalDataDTO
	{
		public PersonalData PersonalData { get; set; }
		public List<ContactInformation> ContactInformationList { get; set; }
	}
}
