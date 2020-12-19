using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI_03_DB_First.Models;

namespace WebAPI_03_DB_First.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Author> Get()
        {
            using (var _context = new BookStoresDBContext())
            {
                // get all authors
                //return _context.Authors.ToList();

                // get author by id
                return _context.Authors.Where(auth => auth.AuthorId == 1).ToList();
            }
        }
    }
}
