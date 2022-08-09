using Amazon.S3.Model;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;

namespace Aiminfomatics.Models
{
	public class HomeViewModel
	{
		public string HomeGraphicImage { get; set; }
		public string HomeGraphicIma1ge { get; set; }
		public string HomeBGImg { get; set; }
		public string HomeInspirin { get; set; }
		public string HomeGraphicText { get; set; }
		public string ReadMore { get; set; }
		public string ResponsiveText { get; set; }
		public string ResponsiveText1 { get; set; }
		public string TechImage { get; set; }
		public string TechnologyText { get; set; }
		public string ResponsiveImg { get; set; }
		public string ResponsiveContentTxt { get; set; }
		public string SupportImg { get; set; }
		public string SupportText { get; set; }
		public string WorldImg { get; set; }
		public string WorldText { get; set; }
		public string Color_pcImg { get; set; }
		public string EvoleText { get; set; }
		public string TwitterTxt { get; set; }
		public string TwArowImg { get; set; }


		public static HomeViewModel GetViewModel(Home home, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever )
		{
			return home == null ? null : new HomeViewModel()
			{
				HomeGraphicImage = $"/getattachment/{home.HomeGraphicImage}/attachment.aspx",
				HomeGraphicIma1ge = $"/getattachment/{home.HomeGraphicIma1ge}/attachment.aspx",
				HomeBGImg = $"/getattachment/{home.HomeBGImg}/attachment.aspx",
				HomeInspirin = home.HomeInspirin,
				HomeGraphicText = home.HomeGraphicText,
				ReadMore = home.ReadMore,
				ResponsiveContentTxt = home.ResponsiveContentTxt,
				ResponsiveText1 = home.ResponsiveText1,
				ResponsiveImg = $"/getattachment/{home.ResponsiveImg}/attachment.aspx",
				ResponsiveText = home.ResponsiveText,
				TechImage = $"/getattachment/{home.TechImage}/attachment.aspx",
				TechnologyText = home.TechnologyText,
				SupportImg = $"/getattachment/{home.SupportImg}/attachment.aspx",
				SupportText = home.SupportText,
				WorldImg =$"/getattachment/{home.WorldImg}/attachment.aspx",
				WorldText = home.WorldText,
				Color_pcImg = $"/getattachment/{home.Color_pcImg}/attachment.aspx",
				EvoleText = home.EvoleText,
				TwitterTxt = home.TwitterTxt,
				TwArowImg = $"/getattachment/{home.TwArowImg}/attachment.aspx"

			};
		}
	}
}
