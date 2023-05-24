using Customer_ProductDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddressHistory>()
                .HasKey(vm => new { vm.CustomerId, vm.AddressId });

            modelBuilder.Entity<CustomerOrder>()
                .HasKey(vm => new { vm.CustomerId, vm.OrderId });

            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<CustomerAddressHistory> CustomerAddressHistories { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<RefAddressType> RefAddressTypes{ get; set; }
        public DbSet<RefOrderStatusCode> RefOrderStatusCodes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RefPaymentMethod> RefPaymentMethods { get; set; }
        public DbSet<RefProductType> RefproductTypes { get; set; }


    }
}
