using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producer>().HasData(new Producer {                
                ProducerId=1,
                Name = "Ionescu Mihai", 
                DeliveryCost = 15, 
                MinimumOrder = 200, 
                PhoneNumber = "0712345678" 
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId=2,
                Name = "Petre Vasile",
                DeliveryCost = 12,
                MinimumOrder = 150,
                PhoneNumber = "0745678123"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId=1,
                Name = "Rosii Bio",
                ProducerId = 1,
                Price=6,
                PhotoUrl="/Images/IonescuMihai/RosiiBio.jpg",
                Weight=1,
                AvailableStock=100            

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Castraveti Bio",
                ProducerId = 1,
                Price = 3,
                PhotoUrl = "/Images/IonescuMihai/CastravetiBio.jpg",
                Weight = 1,
                AvailableStock = 80

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Varza Bio",
                ProducerId = 2,
                Price = 50,
                PhotoUrl = "/Images/PetreVasile/VarzaBio.jpg",
                Weight = 10,
                AvailableStock = 200

            });
        }


    }
}
