using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    { 
        readonly AppDBContext _dbContext;

        public AboutController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<OurTeam> ourTeams = _dbContext.OurTeams.ToList();
            return View(ourTeams);
        }
    }
}
