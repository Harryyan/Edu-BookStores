using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI_01.Model;

namespace WebAPI_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            // CURD
            using (var _context = new BookStoresDbContext())
            {
                /* Publisher publisher = new Publisher();
                 publisher.PublisherName = "test_book_0";

                 _context.Publishers.Add(publisher);
                 _context.SaveChanges();*/

                return _context.Publishers.ToList();
            }

            //return new List<Publisher>();
        }
    }
}
