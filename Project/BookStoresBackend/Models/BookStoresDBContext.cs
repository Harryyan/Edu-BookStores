using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BookStores.Models
{
    public partial class BookStoresDBContext : IdentityDbContext<User>
    {
        public BookStoresDBContext() : base("BookStores") { }

        public BookStoresDBContext(string connectionString) : base(connectionString)
        {

        }
    }
}
