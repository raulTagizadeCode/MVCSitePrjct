using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzz.Areas.Admin.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
