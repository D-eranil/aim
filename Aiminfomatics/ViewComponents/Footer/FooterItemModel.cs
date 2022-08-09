using CMS.Core;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;

namespace Aiminfomatics.ViewComponents
{
	public class FooterItemModel
	{
		public string GetIn { get; set; }
		public string Touch { get; set; }
		public string Social { get; set; }
		public string Media { get; set; }
		public string TwitterImg { get; set; }
		public string TwitterUrl { get; set; }
		public string FacbookImg { get; set; }
		public string FacbookUrl { get; set; }
		public string BribbbleImg { get; set; }
		public string BribbbleUrl { get; set; }
		public string GoogleImg { get; set; }
		public string GoogleUrl { get; set; }
		public string InstagramImg { get; set; }
		public string InstagramUrl { get; set; }
		public string EmailImg { get; set; }
		public string EmailUrl { get; set; }
		public string EmailTxt { get; set; }
		public string EmailIdTxt { get; set; }
		public string PhoneTxt { get; set; }
		public string PhoneNo { get; set; }
		public string Address { get; set; }

		public static FooterItemModel GetModel(SocialLink socialLink)
		{
			var modelData = socialLink == null ? null : new FooterItemModel()
			{
				GetIn = socialLink.GetIn,
				Touch = socialLink.Touch,
				Social = socialLink.Social,
				Media = socialLink.Media,
				TwitterImg = $"/getattachment/{socialLink.TwitterImg}/attachment.aspx",
				TwitterUrl = socialLink.TwitterUrl,
				FacbookImg = $"/getattachment/{socialLink.FacbookImg}/attachment.aspx",
				FacbookUrl = socialLink.FacbookUrl,
				BribbbleImg = $"/getattachment/{socialLink.BribbbleImg}/attachment.aspx",
				BribbbleUrl = socialLink.BribbbleUrl,
				GoogleImg = $"/getattachment/{socialLink.GoogleImg}/attachment.aspx",
				GoogleUrl = socialLink.GoogleUrl,
				InstagramImg = $"/getattachment/{socialLink.InstagramImg}/attachment.aspx",
				InstagramUrl = socialLink.InstagramUrl,
				EmailImg = $"/getattachment/{socialLink.EmailImg}/attachment.aspx",
				EmailUrl = socialLink.EmailUrl,
				EmailTxt = socialLink.EmailTxt,
				EmailIdTxt = socialLink.EmailIdTxt,
				PhoneNo = socialLink.PhoneNo,
				PhoneTxt = socialLink.PhoneTxt,
				Address = socialLink.Address,
			};

			return modelData;
		}
	}
}