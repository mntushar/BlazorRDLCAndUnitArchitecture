using Microsoft.EntityFrameworkCore;
using Models.AppDbContext;
using Repositories.IRepositories;

namespace Repositories.Repositrories
{
    public class Repositorie<TEntity> : IRepositorie<TEntity> where TEntity : class
    {
        public readonly RdlcDbContext context;

        public Repositorie(RdlcDbContext context)
        {
            this.context = context;
        }

        private DbSet<TEntity> Table
        {
            get { return this.context.Set<TEntity>(); }
        }


        public virtual bool Add(TEntity entity)
        {
            Table.Add(entity);
            return this.context.SaveChanges() > 0;
        }

        public virtual bool Update(TEntity entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            return this.context.SaveChanges() > 0;
        }

        public virtual bool Remove(TEntity entity)
        {
            Table.Remove(entity);
            return this.context.SaveChanges() > 0;
        }

        public virtual TEntity GetById(int? id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<TEntity> GetAll()
        {
            return Table.ToList();
        }

        public virtual async Task<List<TEntity>> GetAllList()
        {
            return await Table.ToListAsync();
        }
    }
}
