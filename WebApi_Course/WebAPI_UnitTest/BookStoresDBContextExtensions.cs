using System;
using System.Collections.Generic;
using System.Text;
using WebAPI_08_RepoPattern.Models;

namespace WebAPI_UnitTest
{
    public static class BookStoresDBContextExtensions
    {
        public static void Seed(this BookStoresDBContext dbContext)
        {
            addSmapleAuthorsDataUsing(dbContext);
            addSmaplePublishersDataUsing(dbContext);
        }


        // Private

        private static void addSmapleAuthorsDataUsing(BookStoresDBContext dbContext)
        {
            dbContext.Authors.Add(new Author
            {
                AuthorId = 1,
                LastName = "Yan",
                FirstName = "Harry",
                Phone = "027 366 0259",
                Address = "auckland, new zealand",
                City = "Auckland",
                State = "Auckland",
                Zip = "0614",
                EmailAddress = "harryyan1238@gmail.com",
            });

            dbContext.Authors.Add(new Author
            {
                AuthorId = 2,
                LastName = "T0",
                FirstName = "test0",
                Phone = "027 366 0259",
                Address = "auckland, new zealand",
                City = "Auckland",
                State = "Auckland",
                Zip = "0614",
                EmailAddress = "test0@gmail.com",
            });

            dbContext.Authors.Add(new Author
            {
                AuthorId = 3,
                LastName = "T1",
                FirstName = "test1",
                Phone = "027 366 0259",
                Address = "auckland, new zealand",
                City = "Auckland",
                State = "Auckland",
                Zip = "0614",
                EmailAddress = "test1@gmail.com",
            });

            dbContext.SaveChanges();
        }

        private static void addSmaplePublishersDataUsing(BookStoresDBContext dbContext)
        {
            dbContext.Publishers.Add(new Publisher
            {
               PubId = 1,
               PublisherName = "Harry Yan",
               City = "Auckland",
               State = "Westgate",
               Country = "NZ"
            });

            dbContext.Publishers.Add(new Publisher
            {
                PubId = 2,
                PublisherName = "Lan",
                City = "Auckland",
                State = "Westgate",
                Country = "NZ"
            });

            dbContext.Publishers.Add(new Publisher
            {
                PubId = 3,
                PublisherName = "Snowbean",
                City = "Auckland",
                State = "Westgate",
                Country = "NZ"
            });

            dbContext.SaveChanges();
        }
    }
}