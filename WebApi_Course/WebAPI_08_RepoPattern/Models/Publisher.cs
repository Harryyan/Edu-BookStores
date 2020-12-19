using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_08_RepoPattern.Models
{
    public partial class Publisher : IEntity
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
            Users = new HashSet<User>();
        }

        public int PubId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public int Id
        {
            get
            {
                return PubId;
            }
        }
    }
}
