using System;

namespace MangaDesk.Core.Entities
{
    public class BaseEntity
    {

        public Guid Id { get; set; }

        public DateTime Created { get; set; }


        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
        }

    }
}
