using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test.Data.ViewModels;

namespace test.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var newUrl = new PostUrlVM();
			return View(newUrl);
		}

		public IActionResult ShortenUrl(PostUrlVM postUrlVM)
		{
			return RedirectToAction("Index");
		}
	}
}
