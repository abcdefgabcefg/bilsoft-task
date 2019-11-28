using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class BilSoftTaskContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public BilSoftTaskContext(DbContextOptions<BilSoftTaskContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categories = new[]
            {
                new Category
                {
                    Id = new Guid("ad65906b-6856-44b4-8400-8880419bcffe"),
                    Title = "Category 1"
                },
                new Category
                {
                    Id = new Guid("0195579a-6c52-4759-9360-49957bad6991"),
                    Title = "Category 2"
                },
                new Category
                {
                    Id = new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"),
                    Title = "Category 3"
                },
                new Category
                {
                    Id = new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"),
                    Title = "Category 4"
                },
                new Category
                {
                    Id = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                    Title = "Category 5"
                }
            };

            var products = new[]
            {
                new Product
                {
                    Id = new Guid("f785a54a-6125-4ae5-86e1-18019ed6f23f"),
                    Title = "Product 1",
                    CategoryId = categories[0].Id
                },
                new Product
                {
                    Id = new Guid("7406fc96-a78f-4194-bf1f-26e1b77cc4b2"),
                    Title = "Product 2",
                    CategoryId = categories[0].Id
                },
                new Product
                {
                    Id = new Guid("5ec671a8-24eb-4e5b-aecb-02d05a3c361e"),
                    Title = "Product 3",
                    CategoryId = categories[2].Id
                },
                new Product
                {
                    Id = new Guid("03bdf287-90d4-446c-a08f-bfdaf7a3452a"),
                    Title = "Product 4",
                    CategoryId = categories[3].Id
                },
                new Product
                {
                    Id = new Guid("dd879da5-bf98-4d60-9885-0e258316fa6c"),
                    Title = "Product 5",
                    CategoryId = categories[3].Id
                },
                new Product
                {
                    Id = new Guid("2cf0047b-3cbe-4cc6-aa8b-d692b13c121f"),
                    Title = "Product 6",
                    CategoryId = categories[3].Id
                },
                new Product
                {
                    Id = new Guid("00fa52ea-c324-44ee-a0b7-765f75e674d6"),
                    Title = "Product 7",
                    CategoryId = categories[4].Id
                },
                new Product
                {
                    Id = new Guid("5edaed8f-d8a2-48a3-a0f0-1c7c52b39eac"),
                    Title = "Product 8",
                    CategoryId = categories[4].Id
                },
                new Product
                {
                    Id = new Guid("3735c6c6-f9b1-4249-9a3b-794da2d408d4"),
                    Title = "Product 9",
                    CategoryId = categories[4].Id
                },
                new Product
                {
                    Id = new Guid("56bf4b57-3ebd-4436-a821-6c0575f85686"),
                    Title = "Product 10",
                    CategoryId = categories[4].Id
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);

            var entityTypes = modelBuilder.Model.GetEntityTypes();
            foreach (var entityType in entityTypes)
            {
                var displayName = entityType.DisplayName();
                entityType.SetTableName(displayName);
            }
        }
    }
}
