using MangaDesk.Core.Entities;

namespace MangaDesk.Core.Repositories
{
    public interface IChapterRepository : IRepository<Chapter>
    {

        Task<ICollection<Chapter>> GetChaptersByGroup();

    }
}
