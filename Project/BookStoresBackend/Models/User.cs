using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BookStores.Models
{
    public class User : IdentityUser<Guid>
    {
        public string NickName { get; set; }

        public int Gender { get; set; }

        public ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public ICollection<IdentityUserToken<string>> Tokens { get; set; }

        public ICollection<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
