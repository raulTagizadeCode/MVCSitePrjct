using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;

namespace PurpleBuzz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        readonly AppDBContext _dBContext;

        public ServiceController(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Service> services = _dBContext.Services; 
            return View(services);
        }
    }
}
