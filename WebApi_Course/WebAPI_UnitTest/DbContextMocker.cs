using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI_08_RepoPattern.Models;

namespace WebAPI_UnitTest
{
    public static class DbContextMocker
    {
        public static BookStoresDBContext GetBookStoresDbContext(string dbName)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<BookStoresDBContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new BookStoresDBContext(options);

            // Add entities in memory
            dbContext.Seed();

            return dbContext;
        }
    }
}
