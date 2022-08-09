using Aiminfomatics.Controllers;
using Aiminfomatics.Models;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Services.CLASS_NAME, typeof(ServicesController))]
[assembly: RegisterPageRoute(ServicesSection.CLASS_NAME, typeof(ServicesController))]

namespace Aiminfomatics.Controllers
{
	public class ServicesController : Controller
	{

		private readonly IPageDataContextRetriever pageDataContextRetriever;
		private readonly IPageUrlRetriever pageUrlRetriever;
		private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
		private readonly IPageRetriever pageRetriever;
		private readonly ServicesRepository repository;

		public ServicesController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IPageRetriever pageRetriever, ServicesRepository repository)
		{
			this.pageDataContextRetriever = pageDataContextRetriever;
			this.pageUrlRetriever = pageUrlRetriever;
			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
			this.pageRetriever = pageRetriever;
			this.repository = repository;
		}
		public async Task<IActionResult> Index(CancellationToken cancellationToken)
		{
			var servicesSection = pageDataContextRetriever.Retrieve<ServicesSection>().Page;
			var services = await repository.GetHomeSectionAsync(servicesSection.NodeAliasPath, cancellationToken);

			var viewModel = new ServicesIndexViewModel()
			{
				ServicesSections = services.Select(x => ServicesViewModel.GetViewModel(x, pageUrlRetriever, pageAttachmentUrlRetriever))
			};
			return View(viewModel);
		}
	}
}
