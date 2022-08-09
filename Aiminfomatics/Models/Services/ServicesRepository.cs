using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class ServicesRepository
	{
		private readonly IPageRetriever _pageRetriever;

		public ServicesRepository(IPageRetriever pageRetriever)
		{
			_pageRetriever = pageRetriever;
		}

		public Task<IEnumerable<Services>> GetHomeSectionAsync(string nodeAliasPath, CancellationToken cancellationToken)
		{
			return _pageRetriever.RetrieveAsync<Services>(
					query => query
						.Path(nodeAliasPath, PathTypeEnum.Children)
						.OrderBy("NodeOrder"),
					cache => cache
						.Key($"{nameof(ServicesRepository)} | {nameof(GetHomeSectionAsync)}| {nodeAliasPath}")
						.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()),
					cancellationToken);
		}

		public IEnumerable<Services> GetHomeSections(string nodeAliasPath)
		{
			return _pageRetriever.Retrieve<Services>(
				query => query
					.Path(nodeAliasPath, PathTypeEnum.Children)
					.OrderBy("NodeOrder"),
				cache => cache
					.Key($"{nameof(ServicesRepository)}|{nameof(GetHomeSections)}|{nodeAliasPath}")
					// Include path dependency to flush cache when a new child page is created or page order is changed.
					.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()));
		}
	}
}
