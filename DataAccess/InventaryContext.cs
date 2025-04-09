using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext: DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer("Server=Danny\\MSSQLSERVER01;Database=InventoryDB; User Id=sa;" +
                    "Password=123456;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ELC", CategoryName = "Electrónicos" },
                new CategoryEntity { CategoryId = "RPR", CategoryName = "Reparaciones" },
                new CategoryEntity { CategoryId = "CLT", CategoryName = "Cultura" },
                new CategoryEntity { CategoryId = "SPR", CategoryName = "Deportes" },
                new CategoryEntity { CategoryId = "FDN", CategoryName = "Alimentación" },
                new CategoryEntity { CategoryId = "HME", CategoryName = "Hogar y Muebles" }            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = "WH1", WarehouseName = "Aseo Hogar", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH2", WarehouseName = "Electrónicos", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH3", WarehouseName = "Reparaciones", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH4", WarehouseName = "Cultura", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH5", WarehouseName = "Deportes", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH6", WarehouseName = "Alimentación", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH7", WarehouseName = "Hogar y Muebles", WherehouseAddress = "zona 01" },
                new WarehouseEntity { WarehouseId = "WH8", WarehouseName = "Ropa", WherehouseAddress = "zona 01" }
            );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductId = "P1", ProductName = "Lavadora", ProductDescription = "Lavadora de ropa", TotalQuantity = 10, CategoryId = "ASH" },
                new ProductEntity { ProductId = "P2", ProductName = "Televisor", ProductDescription = "Televisor de 50 pulgadas", TotalQuantity = 10, CategoryId = "ELC" },
                new ProductEntity { ProductId = "P3", ProductName = "Reparación de PC", ProductDescription = "Reparación de PC", TotalQuantity = 10, CategoryId = "RPR" },
                new ProductEntity { ProductId = "P4", ProductName = "Libro", ProductDescription = "Libro de programación", TotalQuantity = 10, CategoryId = "CLT" },
                new ProductEntity { ProductId = "P5", ProductName = "Balón de fútbol", ProductDescription = "Balón de fútbol", TotalQuantity = 10, CategoryId = "SPR" },
                new ProductEntity { ProductId = "P6", ProductName = "Arroz", ProductDescription = "Arroz", TotalQuantity = 10, CategoryId = "FDN" },
                new ProductEntity { ProductId = "P7", ProductName = "Sofá", ProductDescription = "Sofá de 3 puestos", TotalQuantity = 10, CategoryId = "HME" },
                new ProductEntity { ProductId = "P8", ProductName = "Camisa", ProductDescription = "Camisa de vestir", TotalQuantity = 10, CategoryId = "CLT" }
            );

        }
    }
}
