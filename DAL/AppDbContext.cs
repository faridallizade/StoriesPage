using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using StoriesPG.Models;

namespace StoriesPG.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Meals> meals { get; set; }
        public DbSet<RecentWorks> recentWorks { get; set; }
        public DbSet<blogs> blogs { get; set; }

    }
}
