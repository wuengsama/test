using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using test.Data.ViewModels;

namespace test.Controllers
{
	public class AuthenticationController : Controller
	{
		public IActionResult Users()
		{
			return View();
		}

		public IActionResult Login() 
		{
			return View(new LoginVM());
		}

		public IActionResult LoginSubmitted(LoginVM loginVM)
		{
			return View();
		}


		public IActionResult Register()
		{
			return View();
		}
	}
}
