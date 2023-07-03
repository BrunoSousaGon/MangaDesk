using MangaDesk.Core.Entities.Users;
using System;

namespace MangaDesk.Core.Entities
{
    public class TranslatorGroup : BaseEntity
    {

        public string Name { get; set; }

        public string WebSite { get; set; }

        public User Founder { get; set; }

        public ICollection<SocialMedia> SocialMedias { get; set; }

        public ICollection<Book> BooksTranslate { get; set; }

        public ICollection<User> Members { get; set; }

    }
}
