using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI_08_RepoPattern.Repository;
using Xunit;

namespace WebAPI_UnitTest
{
    public class PublishControllerUnitTest
    {
        [Fact]
        public async Task TestGetPublishersAsync()
        {
            // Arrange
            var dbContext = DbContextMocker.GetBookStoresDbContext(nameof(TestGetPublishersAsync));
            var repo = new EFCoreAuthorRepository(dbContext);
            

        }
    }
}
