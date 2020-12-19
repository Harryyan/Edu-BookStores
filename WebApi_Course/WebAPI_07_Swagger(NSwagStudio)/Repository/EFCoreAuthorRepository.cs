using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_07_Swagger.Models;

namespace WebAPI_07_Swagger.Repository
{
    public class EFCoreAuthorRepository : EfCoreRepository<Author, BookStoresDBContext>
    {
        public EFCoreAuthorRepository(BookStoresDBContext context) : base(context)
        {
        }
    }
}
