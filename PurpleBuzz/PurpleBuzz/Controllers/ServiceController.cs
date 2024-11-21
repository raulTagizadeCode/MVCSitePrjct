using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
