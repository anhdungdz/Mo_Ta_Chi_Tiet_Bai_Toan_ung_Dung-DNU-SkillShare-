using DashboardDaiNam.Models;
using Microsoft.EntityFrameworkCore;

namespace DashboardDaiNam.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<HelpPost> HelpPosts { get; set; }
    }
}