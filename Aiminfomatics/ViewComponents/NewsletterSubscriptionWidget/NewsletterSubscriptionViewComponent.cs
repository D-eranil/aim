
using Kentico.PageBuilder.Web.Mvc;
using Aiminfomatics.Widgets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

[assembly: RegisterWidget(NewsletterSubscriptionViewComponent.IDENTIFIER, typeof(NewsletterSubscriptionViewComponent), "Newsletter subscription", typeof(NewsletterSubscriptionProperties), Description = "Displays a form for newsletter subscription.", IconClass = "icon-message")]

namespace Aiminfomatics.Widgets
{
    /// <summary>
    /// Banner widget service.
    /// </summary>
    public class NewsletterSubscriptionViewComponent : ViewComponent
    {
        /// <summary>
        /// Widget identifier.
        /// </summary>
        public const string IDENTIFIER = "Aiminfomatics.NewsletterSubscriptionWidget";


        public ViewViewComponentResult Invoke(ComponentViewModel<NewsletterSubscriptionProperties> viewModel)
        {
            if (User.Identity.IsAuthenticated)
            {
                // Handle authenticated user
                return View("~/ViewComponents/NewsletterSubscriptionWidget/_SubscribeAuthenticated.cshtml");
            }

            return View("~/ViewComponents/NewsletterSubscriptionWidget/_Subscribe.cshtml", new NewsletterSubscriptionSubscribeModel());
        }
    }
}