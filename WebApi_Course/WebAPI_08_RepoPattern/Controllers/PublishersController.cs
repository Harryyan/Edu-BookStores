using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_08_RepoPattern.Models;
using WebAPI_08_RepoPattern.Repository;

namespace WebAPI_08_RepoPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : BaseDBController<Publisher, EfCorePublisherRepository>
    {
        public PublishersController(EfCorePublisherRepository repository) : base(repository)
        {
        }

        // GET: api/Publishers/5
        [HttpGet("GetPublisherDetails/{id}")]
        public async Task<ActionResult<Publisher>> GetPublisherDetails(int id)
        {
            return await repository.GetPublisherDetails(id);
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            return await repository.Put(id, publisher);
        }

        // POST: api/Publishers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
            repository.Add(publisher);

            return CreatedAtAction("GetPublisher", new { id = publisher.PubId }, publisher);
        }
    }
}