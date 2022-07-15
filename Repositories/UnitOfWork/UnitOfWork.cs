using Repositories.AppContext;
using Repositories.IRepositories;
using Repositories.Repositrories;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IDepartmentRepositore _department { get; }

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
        }

        public IDepartmentRepositore Department => _ = _department ?? new DepartmentRepositore(_context);

        public int Commit()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        private bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _context.Dispose();

            disposed = true;
        }
    }
}
