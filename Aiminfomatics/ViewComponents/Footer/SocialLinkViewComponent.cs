using Aiminfomatics.Models;

using CMS.Core;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Linq;


namespace Aiminfomatics.ViewComponents.Components.Footer
{
	public class FooterViewComponent : ViewComponent
	{
		private readonly IPageDataContextRetriever pageDataContextRetriever;
		private readonly IPageUrlRetriever pageUrlRetriever;
		private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
		private readonly IPageRetriever pageRetriever;
		private readonly FooterRepository repository;

		public FooterViewComponent(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever,
									IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IPageRetriever pageRetriever,
									FooterRepository repository)
		{
			this.pageDataContextRetriever = pageDataContextRetriever;
			this.pageUrlRetriever = pageUrlRetriever;
			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
			this.pageRetriever = pageRetriever;
			this.repository = repository;
		}

		public IViewComponentResult Invoke(TreeNode page)
		{
			var viewModel = new FooterItemModel();
			try
			{
				viewModel = repository.GetFooter();
			}
			catch (Exception ex)
			{
				Service.Resolve<IEventLogService>().LogException("HeaderViewComponent", "Invoke", ex);
			}
			return View("~/ViewComponents/Footer/Footer.cshtml", viewModel);
		}
	}
}
