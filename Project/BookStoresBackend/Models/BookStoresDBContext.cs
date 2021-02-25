using Microsoft.AspNet.Identity.EntityFramework;

namespace BookStores.Models
{
    public partial class BookStoresDBContext<TUser>: IdentityDbContext<TUser> where TUser : IdentityUser
    {
        public BookStoresDBContext() : base("BookStores") { }

        public BookStoresDBContext(string connectionString) : base(connectionString)
        {

        }
    }
}
