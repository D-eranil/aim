using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class ContactViewModel
	{

		public string ContactName { get; set; }
		public string Satification { get; set; }
		public string ContactFeel { get; set; }
		public string HeadOffice { get; set; }
		public string AimInfomatics { get; set; }
		public string IndiaTxt { get; set; }
		public string USATxt { get; set; }
		public string SalesMailId { get; set; }
		public string MailText { get; set; }
		public string WebsiteUrl { get; set; }
		public string WebsiteTxt { get; set; }


		public static ContactViewModel GetViewModel(ContactUs coantact, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever pageAttachmentUrlRetriever)
		{
			//var link = coantact?.Fields.SalesMailId.FirstOrDefault();
			
			return coantact == null ? null : new ContactViewModel()
			{


				ContactName = coantact.ContactName,
				Satification = coantact.Satification,
				ContactFeel = coantact.ContactFeel,
				HeadOffice = coantact.HeadOffice,
				AimInfomatics = coantact.AimInfomatics,
				IndiaTxt = coantact.IndiaTxt,
				USATxt = coantact.USATxt,
				SalesMailId = coantact.SalesMailId,                                //link != null ? pageUrlRetriever.Retrieve(link).RelativePath : string.Empty,
				MailText = coantact.MailText,
				WebsiteUrl = coantact.WebsiteUrl,
				WebsiteTxt = coantact.WebsiteTxt
			};
		}
	}
}
