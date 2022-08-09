using Microsoft.Extensions.DependencyInjection;
using Aiminfomatics.Models;
using Aiminfomatics.ViewComponents;

namespace Aiminfomatics.Helpers
{
	public static class IServiceCollectionExtensions
	{
		public static void AddAiminfomaticsServices(this IServiceCollection services)
		{
			AddRepositories(services);
		}
		private static void AddRepositories(IServiceCollection services)
		{
			services.AddSingleton<HomeRepository>();
			services.AddSingleton<AboutRepository>();
			services.AddSingleton<MobileApplicationRepository> ();
			services.AddSingleton<ServicesRepository>();
			services.AddSingleton<FooterRepository>(); 

		}
	}
}
