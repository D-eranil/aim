using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class AboutRepository
	{
		private readonly IPageRetriever _pageRetriever;

		public AboutRepository(IPageRetriever pageRetriever)
		{
			_pageRetriever = pageRetriever;
		}

		public Task<IEnumerable<About>> GetHomeSectionAsync(string nodeAliasPath, CancellationToken cancellationToken)
		{
			return _pageRetriever.RetrieveAsync<About>(
					query => query
						.Path(nodeAliasPath, PathTypeEnum.Children)
						.OrderBy("NodeOrder"),
					cache => cache
						.Key($"{nameof(AboutRepository)} | {nameof(GetHomeSectionAsync)}| {nodeAliasPath}")
						.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()),
					cancellationToken);
		}

		public IEnumerable<About> GetHomeSections(string nodeAliasPath)
		{
			return _pageRetriever.Retrieve<About>(
				query => query
					.Path(nodeAliasPath, PathTypeEnum.Children)
					.OrderBy("NodeOrder"),
				cache => cache
					.Key($"{nameof(AboutRepository)}|{nameof(GetHomeSections)}|{nodeAliasPath}")
					// Include path dependency to flush cache when a new child page is created or page order is changed.
					.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()));
		}
	}
}
