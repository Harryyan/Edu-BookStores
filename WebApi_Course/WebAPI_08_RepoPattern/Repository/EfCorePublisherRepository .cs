using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_08_RepoPattern.Models;

namespace WebAPI_08_RepoPattern.Repository
{
    public class EfCorePublisherRepository : EfCoreRepository<Publisher, BookStoresDBContext>
    {
        public EfCorePublisherRepository(BookStoresDBContext context) : base(context)
        {
        }

        public async Task<Publisher> GetPublisherDetails(int id)
        {
            var publisher = await context.Publishers.SingleAsync(pub => pub.PubId == id);

            /*            context.Entry(publisher)
                            .Collection(pub => pub.Users)
                            .Query()
                            .Where(usr => usr.EmailAddress.Contains("harry"))
                            .Load();

                        context.Entry(publisher)
                            .Collection(pub => pub.Books)
                            .Query()
                            .Include(book => book.Sales)
                            .Load();*/

            if (publisher == null)
            {
                return null;
            }

            return publisher;
        }
    }
}
