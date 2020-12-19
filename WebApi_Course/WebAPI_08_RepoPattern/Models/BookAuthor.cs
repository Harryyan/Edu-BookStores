using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_08_RepoPattern.Models
{
    public partial class BookAuthor : IEntity
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public byte? AuthorOrder { get; set; }
        public int? RoyalityPercentage { get; set; }
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }

        public int Id
        {
            get
            {
                return AuthorId;
            }
        }
    }
}
