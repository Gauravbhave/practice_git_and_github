using Gaurav_git.Models;
using Microsoft.EntityFrameworkCore;

namespace Gaurav_git.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
