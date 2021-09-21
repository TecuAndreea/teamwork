using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsociatiaDeTarani.Models
{
    public class AppDbContext : DbContext
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
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 1,
                Name = "Ionescu Mihai",
                DeliveryCost = 15,
                MinimumOrder = 200,
                PhoneNumber = "0712345678"
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 2,
                Name = "Petre Vasile",
                DeliveryCost = 12,
                MinimumOrder = 150,
                PhoneNumber = "0745678123"
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 4,
                Name = "Mihai Alexandru",
                DeliveryCost = 13,
                MinimumOrder = 120,
                PhoneNumber = "0712345622"
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 5,
                Name = "Costea Andrei",
                DeliveryCost = 15,
                MinimumOrder = 100,
                PhoneNumber = "0798754321"
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 6,
                Name = "Miron Claudiu",
                DeliveryCost = 17,
                MinimumOrder = 180,
                PhoneNumber = "0755533322"
            });
            modelBuilder.Entity<Producer>().HasData(new Producer
            {
                ProducerId = 7,
                Name = "Soare Anisoara",
                DeliveryCost = 19,
                MinimumOrder = 150,
                PhoneNumber = "0711223344"
            });



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Rosii Bio",
                ProducerId = 1,
                Price = 6,
                PhotoUrl = "/Images/IonescuMihai/RosiiBio.jpg",
                Weight = 1,
                AvailableStock = 100
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
                ProductId = 5,
                Name = "Morcovi Bio",
                ProducerId = 1,
                Price = 2,
                PhotoUrl = "/Images/IonescuMihai/morcovi.jpg",
                Weight = 1,
                AvailableStock = 200
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Ridichi Bio",
                ProducerId = 1,
                Price = 10,
                PhotoUrl = "/Images/IonescuMihai/ridichi.jpg",
                Weight = 1,
                AvailableStock = 70

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
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Salata",
                ProducerId = 2,
                Price = 5,
                PhotoUrl = "/Images/PetreVasile/salata1.jpg",
                Weight = 1,
                AvailableStock = 100

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Ceapa",
                ProducerId = 2,
                Price = 50,
                PhotoUrl = "/Images/PetreVasile/ceapa1.jpg",
                Weight = 25,
                AvailableStock = 200

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Cartofi",
                ProducerId = 2,
                Price = 50,
                PhotoUrl = "/Images/PetreVasile/cartofi.jpg",
                Weight = 50,
                AvailableStock = 1500

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Ceapa",
                ProducerId = 4,
                Price = 50,
                PhotoUrl = "/Images/PetreVasile/ceapa1.jfif",
                Weight = 25,
                AvailableStock = 200

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Castraveti Bio",
                ProducerId = 4,
                Price = 35,
                PhotoUrl = "/Images/MihaiAlexandru/castravetiBio.jpg",
                Weight = 10,
                AvailableStock = 200

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Castraveti Bio",
                ProducerId = 4,
                Price = 10,
                PhotoUrl = "/Images/MihaiAlexandru/salata2.jpg",
                Weight = 2,
                AvailableStock = 60

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Ridichi Bio",
                ProducerId = 4,
                Price = 100,
                PhotoUrl = "/Images/MihaiAlexandru/ridichi1.jpg",
                Weight = 10,
                AvailableStock = 300

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Morcovi Bio",
                ProducerId = 4,
                Price = 30,
                PhotoUrl = "/Images/MihaiAlexandru/morcovi1.jfif",
                Weight = 10,
                AvailableStock = 175
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Cartofi Rosii",
                ProducerId = 5,
                Price = 50,
                PhotoUrl = "/Images/CosteaAndrei/cartofiRosii.jpg",
                Weight = 25,
                AvailableStock = 500
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Cartofi",
                ProducerId = 5,
                Price = 25,
                PhotoUrl = "/Images/CosteaAndrei/cartofi2.jpg",
                Weight = 25,
                AvailableStock = 1000
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Ceapa",
                ProducerId = 5,
                Price = 45,
                PhotoUrl = "/Images/CosteaAndrei/ceapa.jpg",
                Weight = 20,
                AvailableStock = 600
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                Name = "Ceapa Rosie",
                ProducerId = 5,
                Price = 60,
                PhotoUrl = "/Images/CosteaAndrei/ceapaRosie.jpg",
                Weight = 25,
                AvailableStock = 300
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                Name = "Castraveti",
                ProducerId = 6,
                Price = 40,
                PhotoUrl = "/Images/MironClaudiu/castraveti.jpg",
                Weight = 10,
                AvailableStock = 300
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                Name = "ceapaRosie1",
                ProducerId = 6,
                Price = 30,
                PhotoUrl = "/Images/MironClaudiu/ceapaRosie1.jpg",
                Weight = 10,
                AvailableStock = 400
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Mere",
                ProducerId = 6,
                Price = 20,
                PhotoUrl = "/Images/MironClaudiu/mere1.jpg",
                Weight = 5,
                AvailableStock = 300
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Ridichi",
                ProducerId = 6,
                Price = 25,
                PhotoUrl = "/Images/MironClaudiu/ridichi.jpg",
                Weight = 3,
                AvailableStock = 300
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                Name = "Cartofi",
                ProducerId = 7,
                Price = 75,
                PhotoUrl = "/Images/SoareAnisoara/cartofi1.jpg",
                Weight = 75,
                AvailableStock = 1200
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Ceapa",
                ProducerId = 7,
                Price = 75,
                PhotoUrl = "/Images/SoareAnisoara/ceapa2.jpg",
                Weight = 30,
                AvailableStock = 700
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 25,
                Name = "Mere",
                ProducerId = 7,
                Price = 20,
                PhotoUrl = "/Images/SoareAnisoara/mere2.jpg",
                Weight = 5,
                AvailableStock = 200
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 26,
                Name = "Morcovi",
                ProducerId = 7,
                Price = 15,
                PhotoUrl = "/Images/SoareAnisoara/morcovi2.jpg",
                Weight = 10,
                AvailableStock = 200
            });
        }


    }
}
