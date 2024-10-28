using Microsoft.AspNetCore.Mvc;

namespace WebECommerce.Controllers
{
	public class Auth : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}
	}
}
