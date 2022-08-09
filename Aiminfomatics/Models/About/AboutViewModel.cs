using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;

namespace Aiminfomatics.Models
{
	public class AboutViewModel
	{
		public string AboutUs { get; set; }
		public string AboutSatisfaction { get; set; }
		public string AboutAimInfomatics { get; set; }

		public static AboutViewModel GetViewModel(About about, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever)
		{
			return about == null ? null : new AboutViewModel()
			{

				AboutUs = about.AboutUs,
				AboutSatisfaction = about.AboutSatisfaction,
				AboutAimInfomatics = about.AboutAimInfomatics,
				

			};
		}
	}
}
