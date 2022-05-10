using Microsoft.EntityFrameworkCore;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore
{
    public class MiniShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        //Dependencies sağ tık add reference ile yada cntrl+. ile add to referance yapabiliriz.
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MiniShopDb");//Veritabanına bakıcak varsa kullanıcak yoksa oluşturacak.
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.CategoryId, pc.ProductId }); //İki primary key yaptık
        }
    }
}
