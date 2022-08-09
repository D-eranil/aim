//using Aiminfomatics.Controllers;
//using Aiminfomatics.Models;
//using Aiminfomatics.ViewComponents.Components.Footer;
//using CMS.DocumentEngine.Types.Aiminfomatics;
//using Kentico.Content.Web.Mvc;
//using Kentico.Content.Web.Mvc.Routing;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;

//[assembly: RegisterPageRoute(SocialLink.CLASS_NAME, typeof(NavigationController))]

//namespace Aiminfomatics.Controllers
//{
//	public class NavigationController : Controller
//    {
//        private readonly IPageDataContextRetriever pageDataContextRetriever;
//        private readonly IPageUrlRetriever pageUrlRetriever;
//        private readonly IPageAttachmentUrlRetriever pageAttachmentUrlRetriever;
//        private readonly IPageRetriever pageRetriever;
//        private readonly FooterRepository repository;


//		public NavigationController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IPageRetriever pageRetriever, FooterRepository repository)
//		{
//			this.pageDataContextRetriever = pageDataContextRetriever;
//			this.pageUrlRetriever = pageUrlRetriever;
//			this.pageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
//			this.pageRetriever = pageRetriever;
//			this.repository = repository;
//		}

//        // GET: Navigation
//        [HttpGet]
//        [Route("Navigation/Footer")]
//        public async Task<IActionResult> Footer (CancellationToken cancellationToken)
//        {
//            var socialLink = pageDataContextRetriever.Retrieve<SocialLink>().Page;
//            var social = await repository.GetHomeSectionAsync(socialLink.NodeAliasPath, cancellationToken);

//            var viewModel = new MenuViewModel()
//            {
//                FooterItems = social.Select(x => FooterItemModel.GetViewModel(x, pageUrlRetriever, pageAttachmentUrlRetriever))
//            };
               
//            return PartialView("_NavFooter", viewModel);
//        }

//        //public ActionResult HeaderIndex()
//        //{
//        //    var menuService = new MenuService();
//        //    var model = new MenuViewModel()
//        //    {
//        //        headers = menuService.GetHeaders()
//        //    };
//        //    return PartialView("_NavHeader", model);
//        //}
//    }
//}