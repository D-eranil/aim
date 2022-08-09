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

[assembly : RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController))]
[assembly :RegisterPageRoute(HomeSection.CLASS_NAME, typeof(HomeController))]

namespace Aiminfomatics.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPageDataContextRetriever pageDataContextRetriever;
		private readonly IPageUrlRetriever pageUrlRetriever;
		private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
		private readonly IPageRetriever pageRetriever;
		private readonly HomeRepository repository;

		public HomeController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IPageRetriever pageRetriever, HomeRepository repository)
		{
			this.pageDataContextRetriever = pageDataContextRetriever;
			this.pageUrlRetriever = pageUrlRetriever;
			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
			this.pageRetriever = pageRetriever;
			this.repository = repository;
		}



		public async Task<IActionResult> Index(CancellationToken cancellationToken)
		{
			var homeSection = pageDataContextRetriever.Retrieve<HomeSection>().Page;
			var home = await repository.GetHomeSectionAsync(homeSection.NodeAliasPath, cancellationToken);

			var viewModel = new HomeIndexViewModel()
			{
				
				HomeSections = home.Select(x => HomeViewModel.GetViewModel(x, pageUrlRetriever, pageAttachmentUrlRetriever))
			};
			return View(viewModel);
		}
	}
}
