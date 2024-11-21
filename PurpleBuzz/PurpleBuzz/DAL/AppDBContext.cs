using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;
namespace PurpleBuzz.DAL
{
    public class AppDBContext : DbContext
    {
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Work> Works { get; set; }

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
