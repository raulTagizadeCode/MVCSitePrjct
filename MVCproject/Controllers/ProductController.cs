using Microsoft.AspNetCore.Mvc;

namespace MVCproject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
