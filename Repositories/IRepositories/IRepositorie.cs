namespace Repositories.IRepositories
{
    public interface IRepositorie<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        TEntity GetById(int? id);
        ICollection<TEntity> GetAll();
        Task<List<TEntity>> GetAllList();
    }
}
