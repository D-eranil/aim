using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;
using Kentico.Content.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aiminfomatics.Models
{
	public class HomeRepository
	{
		private readonly IPageRetriever _pageRetriever;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageRetriever"></param>
		public HomeRepository(IPageRetriever pageRetriever)
		{
			_pageRetriever = pageRetriever;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="nodeAliasPath"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<IEnumerable<Home>> GetHomeSectionAsync(string nodeAliasPath, CancellationToken cancellationToken)
		{
			return _pageRetriever.RetrieveAsync<Home>(
					query => query
						.Path(nodeAliasPath, PathTypeEnum.Children)
						.OrderBy("NodeOrder"),
					cache => cache
						.Key($"{nameof(HomeRepository)} | {nameof(GetHomeSectionAsync)}| {nodeAliasPath}")
						.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()),
					cancellationToken);
		}

		public IEnumerable<Home> GetHomeSections(string nodeAliasPath)
		{
			return _pageRetriever.Retrieve<Home>(
				query => query
					.Path(nodeAliasPath, PathTypeEnum.Children)
					.OrderBy("NodeOrder"),
				cache => cache
					.Key($"{nameof(HomeRepository)}|{nameof(GetHomeSections)}|{nodeAliasPath}")
					// Include path dependency to flush cache when a new child page is created or page order is changed.
					.Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()));
		}
	}
}
