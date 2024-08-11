using Microsoft.AspNetCore.Mvc;
using test.Data.Models;
using test.Data.ViewModels;

namespace test.Controllers
{
	public class UrlController : Controller
	{
		public IActionResult Index() 
		{
			//Fake DB
			var allUrls = new List<GetUrlVM>()
			{
				new GetUrlVM()
				{
					Id = 1,
					OriginalLink = "https://link1.com",
					ShortLink = "sh1",
					NrOfClicks = 1,
					UserId = 1,

				},
				new GetUrlVM()
				{
					Id = 2,
					OriginalLink = "https://link2.com",
					ShortLink = "sh2",
					NrOfClicks = 2,
					UserId = 2,

				}
			};

			return View(allUrls);
		}

		public IActionResult Create()
		{
			

			return RedirectToAction("Index");
		}

		public IActionResult Remove(int id)
		{
			return View();
		}

		public IActionResult Remove(int userId, int linkId)
		{
			return View();
		}
	}
}
