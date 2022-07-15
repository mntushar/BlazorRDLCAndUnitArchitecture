using Models;
using Repositories.AppContext;
using Repositories.IRepositories;

namespace Repositories.Repositrories
{
    public class DepartmentRepositore : Repositorie<DepartmentModel>, IDepartmentRepositore
    {
        public DepartmentRepositore(AppDbContext context) : base(context)
        {
        }
    }
}
