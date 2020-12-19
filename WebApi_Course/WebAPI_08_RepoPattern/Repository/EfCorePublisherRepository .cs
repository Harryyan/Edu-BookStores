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
    }
}
