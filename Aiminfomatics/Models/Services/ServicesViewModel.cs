using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Linq;

namespace Aiminfomatics.Models
{
	public class ServicesViewModel
	{
		public string Services { get; set; }
		public string ServicesSatisfaction { get; set; }
		public string OurServices { get; set; }
		public string MobileApplication { get; set; }
		public string MobileApplicationImg { get; set; }
		public string WebDesignDevelopment { get; set; }
		public string WebDesignImg { get; set; }
		public string InternetMarketin { get; set; }
		public string SeoImg { get; set; }
		public string ECommerceSolutions { get; set; }
		public string EcomImg { get; set; }
		public string SoftwareDevelopment { get; set; }
		public string SoftwareImg { get; set; }
		public string HireDeveloper { get; set; }
		public string HireImg { get; set; }
		public string RelatedButtonUrl { get; set; }
		public string HireDeveloperRelatedPage { get; set; }
		public string WebDesAndDeveRelatedPage { get; set; }
		public string WebSoftRelatedPage { get; set; }
		public string SeoRelatedPage { get; set; }
		public string ECommerceRelatedPage { get; set; }

		public static ServicesViewModel GetViewModel(Services services, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever)
		{
			var link = services?.Fields.RelatedPage.FirstOrDefault();
			var link1 = services?.Fields.HireDeveloperRelatedPage.FirstOrDefault();
			var link2 = services?.Fields.WebDesAndDeveRelatedPage.FirstOrDefault();
			var link3 = services?.Fields.WebSoftRelatedPage.FirstOrDefault();
			var link4 = services?.Fields.SeoRelatedPage.FirstOrDefault();
			var link5 = services?.Fields.ECommerceRelatedPage.FirstOrDefault();
			return services == null ? null : new ServicesViewModel()
			{

				RelatedButtonUrl = link != null ? pageUrlRetriever.Retrieve(link).RelativePath : string.Empty,
				HireDeveloperRelatedPage = link1 != null ? pageUrlRetriever.Retrieve(link1).RelativePath : string.Empty,
				WebDesAndDeveRelatedPage = link2 != null ? pageUrlRetriever.Retrieve(link2).RelativePath : string.Empty,
				WebSoftRelatedPage = link3 != null ? pageUrlRetriever.Retrieve(link3).RelativePath : string.Empty,
				SeoRelatedPage = link4 != null ? pageUrlRetriever.Retrieve(link4).RelativePath : string.Empty,
				ECommerceRelatedPage = link5 != null ? pageUrlRetriever.Retrieve(link5).RelativePath : string.Empty,
				Services = services.Services1,
				ServicesSatisfaction = services.ServicesSatisfaction,
				OurServices = services.OurServices,
				MobileApplication = services.MobileApplication,
				MobileApplicationImg = $"/getattachment/{services.MobileApplicationImg}/attachment.aspx",
				WebDesignDevelopment = services.WebDesignDevelopment,
				WebDesignImg = $"/getattachment/{services.WebDesignImg}/attachment.aspx",
				InternetMarketin= services.InternetMarketin,
				SeoImg = $"/getattachment/{services.SeoImg}/attachment.aspx",
				ECommerceSolutions = services.ECommerceSolutions,
				EcomImg = $"/getattachment/{services.EcomImg}/attachment.aspx",
				SoftwareDevelopment = services.SoftwareDevelopment,
				SoftwareImg = $"/getattachment/{services.SoftwareImg}/attachment.aspx",
				HireDeveloper = services.HireDeveloper,
				HireImg = $"/getattachment/{services.SoftwareImg}/attachment.aspx",
			};
		}
	}
}
