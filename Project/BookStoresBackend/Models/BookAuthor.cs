using System;
using System.Collections.Generic;

#nullable disable

namespace BookStoresBackend.Models
{
    public class BookAuthor
    {
        public Guid Id { get; set; }
        public int BookId { get; set; }
        public byte? AuthorOrder { get; set; }
        public int? RoyalityPercentage { get; set; }
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
