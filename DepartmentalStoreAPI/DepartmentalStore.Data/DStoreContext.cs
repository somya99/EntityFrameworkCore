using DepartmentalStoreAPI.DepartmentalStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.DepartmentalStore.Data
{
    public class DStoreContext : DbContext
    {
        private readonly IConfiguration _config;

        public DStoreContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<StaffRole> StaffRole { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Supply> Supply { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString("DStore"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Address
            modelBuilder.Entity<Address>().HasKey(r => r.AddressId);
            modelBuilder.Entity<Address>().Property(x => x.AddressLine1).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.AddressLine2).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.City).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.State).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.Pincode).HasMaxLength(6).IsRequired();

            //Configure StaffRole
            modelBuilder.Entity<StaffRole>().HasKey(r => r.StaffRoleId);
            modelBuilder.Entity<StaffRole>().Property(x => x.RoleName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<StaffRole>().Property(x => x.Description).HasMaxLength(1024);

            //Configure Staff
            modelBuilder.Entity<Staff>().HasKey(r => r.StaffId);
            modelBuilder.Entity<Staff>().Property(x => x.FirstName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.LastName).HasMaxLength(64);
            modelBuilder.Entity<Staff>().Property(x => x.PhoneNo).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Gender).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<Staff>().HasOne(s => s.Address).WithMany(a => a.Staff).HasForeignKey(x => x.AddressId);
            modelBuilder.Entity<Staff>().HasOne(s => s.StaffRole).WithMany(a => a.Staff).HasForeignKey(x => x.StaffRoleId);
            modelBuilder.Entity<Staff>().Property(x => x.Salary).IsRequired();

            //Configure Category
            modelBuilder.Entity<Category>().HasKey(r => r.CategoryId);
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Category>().Property(x => x.Description).HasMaxLength(1024);

            //Configure Product
            modelBuilder.Entity<Product>().HasKey(r => r.ProductId);
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.ProductCode).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Manufacturer).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.CurrentQuantity).IsRequired();

            //Configure ProductCategory
            modelBuilder.Entity<ProductCategory>().HasKey(s => new { s.ProductId, s.CategoryId });

            //Configure ProductDetail
            modelBuilder.Entity<ProductDetail>().HasKey(r => r.ProductId);
            modelBuilder.Entity<ProductDetail>().HasOne(s => s.Product).WithOne(a => a.ProductDetail).HasForeignKey<ProductDetail>(x => x.ProductId);
            modelBuilder.Entity<ProductDetail>().Property(x => x.CostPrice).IsRequired();
            modelBuilder.Entity<ProductDetail>().Property(x => x.SellingPrice).IsRequired();
            modelBuilder.Entity<ProductDetail>().Property(x => x.DateOfManufacture).IsRequired();

            //Configure Inventory
            modelBuilder.Entity<Inventory>().HasKey(r => r.InventoryId);
            modelBuilder.Entity<Inventory>().HasOne(s => s.Product).WithOne(a => a.Inventory).HasForeignKey<Inventory>(x => x.ProductId);
            modelBuilder.Entity<Inventory>().Property(x => x.TotalQuantity).IsRequired();
            modelBuilder.Entity<Inventory>().Property(x => x.InStock).IsRequired();

            //Configure Supplier
            modelBuilder.Entity<Supplier>().HasKey(r => r.SupplierId);
            modelBuilder.Entity<Supplier>().Property(x => x.FirstName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.LastName).HasMaxLength(64);
            modelBuilder.Entity<Supplier>().Property(x => x.PhoneNo).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.Email).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.City).HasMaxLength(64).IsRequired();

            //Configure Supply
            modelBuilder.Entity<Supply>().HasKey(r => r.SupplyId);
            modelBuilder.Entity<Supply>().HasOne(s => s.Product).WithMany(a => a.Supply).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<Supply>().HasOne(s => s.Supplier).WithMany(a => a.Supply).HasForeignKey(x => x.SupplierId);
            modelBuilder.Entity<Supply>().Property(x => x.DateOfSupply).IsRequired();
            modelBuilder.Entity<Supply>().Property(x => x.QuantitySupplied).IsRequired();

            base.OnModelCreating(modelBuilder);
        }

    }
}
