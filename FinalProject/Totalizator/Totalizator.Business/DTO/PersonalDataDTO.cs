using System.Collections.Generic;
using Totalizator.Shared;

namespace Totalizator.Business.DTO
{
	public class PersonalDataDTO
	{
		internal PersonalDataViewModel PersonalData { get; set; }

		internal IEnumerable<ContactInformationViewModel> ContactInformationList { get; set; }
	}
}