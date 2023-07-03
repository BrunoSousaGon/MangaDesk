using System;

namespace MangaDesk.Core.Entities
{
    public class BookAuthor : BaseEntity
    {

        public Guid Bookid { get; set; }

        public Book Book { get; set; }


        public Guid AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
