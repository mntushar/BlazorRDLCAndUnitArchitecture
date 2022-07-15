using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories.AppContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<DepartmentModel>? Department { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
