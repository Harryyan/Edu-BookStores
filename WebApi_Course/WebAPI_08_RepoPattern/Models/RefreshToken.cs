using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_08_RepoPattern.Models
{
    public partial class RefreshToken : IEntity
    {
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual User User { get; set; }

        public int Id
        {
            get
            {
                return TokenId;
            }
        }
    }
}
