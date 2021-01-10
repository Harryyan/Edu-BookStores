using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI_08_RepoPattern.Repository;
using Xunit;
using WebAPI_08_RepoPattern.Controllers;
using WebAPI_08_RepoPattern.Models;

namespace WebAPI_UnitTest
{
    public class PublishControllerUnitTest
    {
        [Fact]
        public async Task TestGetPublishersAsync()
        {
            // Arrange
            var dbContext = DbContextMocker.GetBookStoresDbContext(nameof(TestGetPublishersAsync));
            var repo = new EfCorePublisherRepository(dbContext);
            var controller = new PublishersController(repo);

            // Act
            var response = await controller.Get() as ActionResult<IEnumerable<Publisher>>;
            var value = response.Value as List<Publisher>;

            dbContext.Dispose();

            // Asserts
            Assert.True(value.Count == 3);
        }
    }
}
