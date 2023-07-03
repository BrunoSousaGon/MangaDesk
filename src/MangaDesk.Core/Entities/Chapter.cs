using System;

namespace MangaDesk.Core.Entities
{
    public class Chapter : BaseEntity
    {

        public string Name { get; set; }

        public int Chapternumber { get; set; }

        public int Pages { get; set; }

        public bool PartnerGroup { get; set; }

        public bool SubChapter { get; set; }

        public ICollection<ImageBook> Images { get; set; }

        public ICollection<TranslatorGroup> TranslatorGroups { get; set; }

        public ICollection<Chapter> SubChapters { get; set; }


        public Guid IdBook { get; set; }

        public Book Book { get; set; }


    }
}
