using Microsoft.EntityFrameworkCore;
using Test01.Model;

namespace Test01.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                         
        }

        public DbSet<Courses>Courses { get; set; }
        public DbSet<Students>Students { get; set; }
    }
}
