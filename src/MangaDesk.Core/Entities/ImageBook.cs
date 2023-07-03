using System;

namespace MangaDesk.Core.Entities
{
    public class ImageBook : BaseEntity
    {

        public string Path { get; set; }

        public Guid ChapterId { get; set; }

        public Chapter Chapter { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

    }
}
