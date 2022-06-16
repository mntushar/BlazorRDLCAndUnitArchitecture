namespace Repositories.IRepositories
{
    public interface IRepositorie<TEntity> where TEntity : class
    {
        public bool Add(TEntity entity);
        public bool Update(TEntity entity);
        public bool Remove(TEntity entity);
        public TEntity GetById(int? id);
        public ICollection<TEntity> GetAll();
        public Task<List<TEntity>> GetAllList();
    }
}
