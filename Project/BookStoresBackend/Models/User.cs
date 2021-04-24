using System;
using System.Collections.Generic;

#nullable disable

namespace BookStoresBackend.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Source { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public short? RoleId { get; set; }
        public int PubId { get; set; }
        public DateTime? HireDate { get; set; }
        public virtual Publisher Pub { get; set; }
        public virtual Role Role { get; set; }
    }
}
