using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStores.Models
{
    public partial class BookStoresDBContext : IdentityDbContext<User>
    {
        public BookStoresDBContext(DbContextOptions<BookStoresDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
