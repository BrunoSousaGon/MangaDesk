using System;
using MangaDesk.Core.Entities;

namespace MangaDesk.Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {

        Task<ICollection<Book>> GetAll();

        Task<ICollection<Book>> GetByGenre();

        Task<ICollection<Book>> GetByAuthor();

    }
}
