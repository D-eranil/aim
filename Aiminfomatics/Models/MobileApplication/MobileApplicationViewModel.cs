using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;

namespace Aiminfomatics.Models
{
	public class MobileApplicationViewModel
	{
		public string MobileApplication { get; set; }
		public string Satisfaction { get; set; }
		public string MobileApp { get; set; }
		//public string InternetMarketing { get; set; }
		//public string ECommerceSol { get; set; }
		//public string HireDeveloper { get; set; }
		//public string MobileAppDevText { get; set; }
		//public string WeWorkIn { get; set; }


		public static MobileApplicationViewModel GetViewModel(MobileApplication mobilApplication, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever)
		{
			return mobilApplication == null ? null : new MobileApplicationViewModel()
			{

				MobileApplication = mobilApplication.MobileApplication1,
				Satisfaction = mobilApplication.Satification,
				MobileApp = mobilApplication.MobileApp,



			};
		}
	}
}
