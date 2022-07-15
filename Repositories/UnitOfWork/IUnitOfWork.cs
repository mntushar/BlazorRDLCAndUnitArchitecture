using Repositories.IRepositories;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDepartmentRepositore Department { get; }

        int Commit();
        Task<int> CommitAsync();
    }
}
