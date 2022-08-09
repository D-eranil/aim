using Aiminfomatics.Models;
using Aiminfomatics.ViewComponents;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using CMS.SiteProvider;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class FooterRepository
	{
		private readonly IPageRetriever _pageRetriever;
		private readonly bool enableCache;

		public FooterRepository(IPageRetriever pageRetriever)
		{
			_pageRetriever = pageRetriever;
			enableCache = SettingsKeyInfoProvider.GetBoolValue(SiteContext.CurrentSiteName + Constants.EnableCache);

		}

		public FooterItemModel GetFooter()
		{
			FooterItemModel footerViewModel = new FooterItemModel();
			SocialLink footerPage = new SocialLink();
			try
			{
				Action<DocumentQuery<SocialLink>> pageQuery = query => query.Published(true)
						   .OnSite(SiteContext.CurrentSiteName)
						   .Columns(
								"GetIn", "Touch", "Social", "Media",
								"TwitterImg", "TwitterUrl", "FacbookImg", "FacbookUrl",
								"BribbbleImg", "BribbbleUrl", "GoogleImg",
								"GoogleUrl", "InstagramImg", "InstagramUrl",
								"EmailImg", "EmailUrl", "EmailTxt", "EmailIdTxt",
								"PhoneTxt", "PhoneNo", "Address", "NodeOrder",
								"NodeAliasPath"
						   )
						   .OrderBy("NodeOrder")
						   .FirstOrDefault();

				if (enableCache)
				{
					footerPage = _pageRetriever.RetrieveAsync(
						pageQuery,
						cache => cache
							.Key($"{nameof(FooterRepository)}|{nameof(GetFooter)}")
							// Include path dependency to flush cache when a new child page is created or page order is changed.
							.Dependencies((_, builder) => builder.PagePath("/layout/footer", PathTypeEnum.Children).PageOrder()),
						new CancellationToken())?.Result.FirstOrDefault();
				}
				else
				{
					footerPage = _pageRetriever.RetrieveAsync(
						pageQuery)?.Result.FirstOrDefault();
				}
				//bind local model
				footerViewModel = FooterItemModel.GetModel(footerPage);
			}
			catch (Exception ex)
			{
				throw ex;
			}


			return footerViewModel;
		}














	}
}
