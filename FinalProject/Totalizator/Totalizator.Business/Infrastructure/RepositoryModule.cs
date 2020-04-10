using Ninject.Modules;
using Totalizator.Data.Repositories.Interfaces;
using Totalizator.Data.Repositories.Realizations;

namespace Totalizator.Business.Infrastructure
{
	public class RepositoryModule : NinjectModule
	{
		private readonly string connectionString;

		public RepositoryModule(string connection)
		{
			connectionString = connection;
		}

		public override void Load()
		{
			Bind<IBetRepository>().To<BetRepository>()
				.WithConstructorArgument(connectionString);

			Bind<IContactInformationRepository>().To<ContactInformationRepository>()
				.WithConstructorArgument(connectionString);

			Bind<IPersonalDataRepository>().To<PersonalDataRepository>()
				.WithConstructorArgument(connectionString);

			Bind<ISportEventRepository>().To<SportEventRepository>()
				.WithConstructorArgument(connectionString);

			Bind<ITeamRepository>().To<TeamRepository>()
				.WithConstructorArgument(connectionString);

			Bind<IUserRepository>().To<UserRepository>()
				.WithConstructorArgument(connectionString);
		}
	}
}
