using Microsoft.AspNetCore.Mvc;

namespace Aiminfomatics.Controllers
{
	public class ServicesItemController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
