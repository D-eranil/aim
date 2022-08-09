using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class MobileApplicationRepository
	{
		private readonly IPageRetriever _pageRetriever;

		public MobileApplicationRepository(IPageRetriever pageRetriever)
		{
			_pageRetriever = pageRetriever;
		}

		public Task<IEnumerable<MobileApplication>> GetHomeSectionAsync(string nodeAliasPath, CancellationToken cancellationToken)
		{
			return _pageRetriever.RetrieveAsync<MobileApplication>(
					query => query
						.Path(nodeAliasPath, PathTypeEnum.Children)
						.OrderBy("NodeOrder"),
					cache => cache
						.Key($"{nameof(MobileApplicationRepository)} | {nameof(GetHomeSectionAsync)}| {nodeAliasPath}")
						.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()),
					cancellationToken);
		}

		public IEnumerable<MobileApplication> GetHomeSections(string nodeAliasPath)
		{
			return _pageRetriever.Retrieve<MobileApplication>(
				query => query
					.Path(nodeAliasPath, PathTypeEnum.Children)
					.OrderBy("NodeOrder"),
				cache => cache
					.Key($"{nameof(MobileApplicationRepository)}|{nameof(GetHomeSections)}|{nodeAliasPath}")
					// Include path dependency to flush cache when a new child page is created or page order is changed.
					.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()));
		}
	}
}
