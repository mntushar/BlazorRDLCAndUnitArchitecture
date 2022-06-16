using Models;
using Models.AppDbContext;
using Repositories.IRepositories;

namespace Repositories.Repositrories
{
    public class DepartmentRepositore : Repositorie<DepartmentModel>, IDepartmentRepositore
    {
        public DepartmentRepositore(RdlcDbContext context) : base(context)
        {
        }
    }
}
