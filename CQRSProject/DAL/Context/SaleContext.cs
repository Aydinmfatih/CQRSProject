using CQRSProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL.Context
{
    public class SaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;initial Catalog=SaleDb;integrated Security=true");

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}

