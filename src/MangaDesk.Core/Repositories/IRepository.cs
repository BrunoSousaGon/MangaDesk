using MangaDesk.Core.Entities;

namespace MangaDesk.Core.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);

        Task<ICollection<TEntity>> FindAll(int id);

        Task<TEntity> FindById(Guid id);

        Task<bool> SaveChanges();

    }
}
