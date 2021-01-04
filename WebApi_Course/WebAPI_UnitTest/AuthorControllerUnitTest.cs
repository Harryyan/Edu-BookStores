using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_08_RepoPattern.Controllers;
using WebAPI_08_RepoPattern.Models;
using WebAPI_08_RepoPattern.Repository;
using Xunit;

namespace WebAPI_UnitTest
{
    public class AuthorControllerUnitTest
    {
        [Fact]
        public async Task TestGetAuthorsAsync()
        {
            // Arrange
            var dbContext = DbContextMocker.GetBookStoresDbContext(nameof(TestGetAuthorsAsync));
            var repo = new EFCoreAuthorRepository(dbContext);
            var controller = new AuthorController(repo);

            // Act
            var response = await controller.Get() as ActionResult<IEnumerable<Author>>;
            var value = response.Value as List<Author>;

            dbContext.Dispose();

            // Assert
            Assert.True(value.Count == 3);
        }

        [Fact]
        public async Task TestGetAuthorByIdAsync()
        {
            // Arrange
            var dbContext = DbContextMocker.GetBookStoresDbContext(nameof(TestGetAuthorByIdAsync));
            var repo = new EFCoreAuthorRepository(dbContext);
            var controller = new AuthorController(repo);
            var id = 1;

            // Act
            var response = await controller.Get(id) as ActionResult<Author>;
            var value = response.Value as Author;

            dbContext.Dispose();

            // Assert
            Assert.True(value.FirstName == "Harry");
        }

        [Fact]
        public async Task TestDeleteAuthorAsync()
        {
            // Arrange
            var dbContext = DbContextMocker.GetBookStoresDbContext(nameof(TestDeleteAuthorAsync));
            var repo = new EFCoreAuthorRepository(dbContext);
            var controller = new AuthorController(repo);
            var id = 1;

            // Act
            var deleteResponse = await controller.Delete(id) as ActionResult<Author>;
            var fetchResponse = await controller.Get() as ActionResult<IEnumerable<Author>>;
            var value = fetchResponse.Value as List<Author>;

            dbContext.Dispose();

            // Assert
            Assert.True(value.Count == 2);
        }
    }
}
