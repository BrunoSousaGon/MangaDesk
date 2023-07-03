using System;

namespace MangaDesk.Core.Entities
{
    public class AlternativeName : BaseEntity
    {

        public string Name { get; set; }

        public Guid Bookid { get; set; }

    }
}
