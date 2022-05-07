using Microsoft.EntityFrameworkCore;

namespace angular_test_project.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Scene> Scenes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}