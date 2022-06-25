using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities.concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.concrete.EntityFrameWork
{
    public class NorthwindContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
            Database=Northwind;Trusted_Connection=true");
        }
    }
}
