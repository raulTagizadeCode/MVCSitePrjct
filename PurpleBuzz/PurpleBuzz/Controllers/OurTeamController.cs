using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;

namespace PurpleBuzz.Controllers
{
    public class OurTeamController : Controller
    {
        readonly AppDBContext _dbContext;

        public OurTeamController(AppDBContext dbContext)
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
