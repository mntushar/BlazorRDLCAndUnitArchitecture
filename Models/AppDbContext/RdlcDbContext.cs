using Microsoft.EntityFrameworkCore;

namespace Models.AppDbContext
{
    public class RdlcDbContext : DbContext
    {
        public DbSet<DepartmentModel>? Department { get; set; }

        public RdlcDbContext(DbContextOptions<RdlcDbContext> options)
            : base(options)
        {
        }
    }
}
