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

[assembly: RegisterPageRoute(About.CLASS_NAME, typeof(AboutController))]
[assembly: RegisterPageRoute(AboutSection.CLASS_NAME, typeof(AboutController))]

namespace Aiminfomatics.Controllers
{
	public class AboutController : Controller
	{

		private readonly IPageDataContextRetriever pageDataContextRetriever;
		private readonly IPageUrlRetriever pageUrlRetriever;
		private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
		private readonly IPageRetriever pageRetriever;
		private readonly AboutRepository repository;

		public AboutController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IPageRetriever pageRetriever, AboutRepository repository)
		{
			this.pageDataContextRetriever = pageDataContextRetriever;
			this.pageUrlRetriever = pageUrlRetriever;
			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
			this.pageRetriever = pageRetriever;
			this.repository = repository;
		}

		public async Task<IActionResult> Index(CancellationToken cancellationToken)
		{
			var aboutSection = pageDataContextRetriever.Retrieve<AboutSection>().Page;
			var about = await repository.GetHomeSectionAsync(aboutSection.NodeAliasPath, cancellationToken);

			var viewModel = new AboutIndexViewModel()
			{
				AboutSections = about.Select(x => AboutViewModel.GetViewModel(x, pageUrlRetriever, pageAttachmentUrlRetriever))
			};
			return View(viewModel);
		}
	}
}

