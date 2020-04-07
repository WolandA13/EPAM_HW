using System.Security.Principal;

namespace Totalizator.Web.Models
{
	public class User : IPrincipal
	{
		public IIdentity Identity { get; }

		public bool IsInRole(string role)
		{
			throw new System.NotImplementedException();
		}
	}
}