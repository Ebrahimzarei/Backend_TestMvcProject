using Backend_TestedProject.Domains;

namespace Backend_TestedProject.Contract.Common
{
    public interface IBaseRepository<TEntity> where TEntity :BaseEntity, new()
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        void Delete(int id);
        TEntity Add(TEntity entity);

        TEntity Update(int id, TEntity entity);
    }
}
