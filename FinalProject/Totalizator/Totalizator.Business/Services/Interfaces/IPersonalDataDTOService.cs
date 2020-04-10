using Totalizator.Business.DTO;

namespace Totalizator.Business.Services.Interfaces
{
	public interface IPersonalDataDTOService
	{
		PersonalDataDTO GetById(int id);
	}
}
