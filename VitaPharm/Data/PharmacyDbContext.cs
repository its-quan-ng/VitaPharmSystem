using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace VitaPharm.Data
{
    class PharmacyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<GoodsReceipt> GoodsReceipts { get; set; }
        public DbSet<GoodsReceiptDetail> GoodsReceiptDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PharmacyConnection"].ConnectionString);
        }
    }
}
