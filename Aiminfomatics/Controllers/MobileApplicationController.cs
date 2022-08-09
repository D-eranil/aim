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

[assembly: RegisterPageRoute(MobileApplication.CLASS_NAME, typeof(MobileApplicationController))]
[assembly: RegisterPageRoute(MobileApplicationSection.CLASS_NAME, typeof(MobileApplicationController))]

namespace Aiminfomatics.Controllers
{
	public class MobileApplicationController : Controller
	{

		private readonly IPageDataContextRetriever pageDataContextRetriever;
		private readonly IPageUrlRetriever pageUrlRetriever;
		private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
		private readonly IPageRetriever pageRetriever;
		private readonly MobileApplicationRepository mobileApplicationRepository;

		public MobileApplicationController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever,
											IPageRetriever pageRetriever, MobileApplicationRepository mobileApplicationRepository)
		{
			
			this.pageDataContextRetriever = pageDataContextRetriever;
			this.pageUrlRetriever = pageUrlRetriever;
			this.mobileApplicationRepository = mobileApplicationRepository;
			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
			this.pageRetriever = pageRetriever;	
		}


		public async Task<IActionResult> Index(CancellationToken cancellationToken)
		{
			var mobileApplicationSection = pageDataContextRetriever.Retrieve<MobileApplicationSection>().Page;
			var mobileApplication = await mobileApplicationRepository.GetHomeSectionAsync(mobileApplicationSection.NodeAliasPath, cancellationToken);

			var viewModel = new MobileApplicationIndexViewModel()
			{
				MobileApplicationSections = mobileApplication.Select(x => MobileApplicationViewModel.GetViewModel(x, pageUrlRetriever, pageAttachmentUrlRetriever))
			};
			return View(viewModel);
		}
	}
}
