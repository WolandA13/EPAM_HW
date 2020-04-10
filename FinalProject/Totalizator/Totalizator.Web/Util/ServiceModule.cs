using Ninject.Modules;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Business.Services.Realizations;

namespace Totalizator.Web.Util
{
	public class ServiceModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IBetService>().To<BetService>();

			Bind<IContactInformationService>().To<ContactInformationService>();

			Bind<IPersonalDataDTOService>().To<PersonalDataDTOService>();
			
			Bind<IPersonalDataService>().To<PersonalDataService>();

			Bind<ISportEventService>().To<SportEventService>();

			Bind<ITeamService>().To<TeamService>();

			Bind<IUserService>().To<UserService>();
		}
	}
}