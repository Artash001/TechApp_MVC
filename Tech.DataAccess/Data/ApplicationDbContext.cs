using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tech.Models;


namespace Tech.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Engine", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Transmission", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Steering System", DisplayOrder = 3 }
            );

        modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "BMW Group", StreetAddress="123 bmw", City="Munich", State="IL", PostalCode="19746",PhoneNumber="546548646"},
                new Company { Id = 2, Name = "Daimler", StreetAddress = "123 Daimler", City = "Berlin", State = "MY", PostalCode = "48923", PhoneNumber = "987982329" },
                new Company { Id = 3, Name = "VAG Group", StreetAddress = "123 Vag", City = "Dortmund", State = "RT", PostalCode = "89721", PhoneNumber = "213656899" }
            );

        modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Crankshaft",
                    Manufacturer = "BMW Group",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Brake Pads",
                    Manufacturer = "Volkswagen Group",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Gas Pedal",
                    Manufacturer = "Febi Bilstein",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "ABS Sensor",
                    Manufacturer = "Mercedes-Benz AG",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Transmission",
                    Manufacturer = "Lemforder",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Oil Filter",
                    Manufacturer = "Stellox",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                }
            );
    }
}
