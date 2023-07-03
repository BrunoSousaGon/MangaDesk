using MangaDesk.Core.Enums;

namespace MangaDesk.Core.Entities
{
    public class Book : BaseEntity
    {

        public string Name { get; set; }

        public string Summary { get; set; }

        public ImageBook CoverImage { get; set; }

        public long Views { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ICollection<Chapter> Chapters { get; set; }

        public ICollection<AlternativeName> AlternativeNames { get; set; }

        public ICollection<Author> Authors { get; set; }



        // Enums
        public Status Status { get; set; }

        public BookType Type { get; set; }


    }
}
