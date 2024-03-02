using Microsoft.EntityFrameworkCore;
using MyBlog_IoTAutomation.EntityLayer.Entities.Concrete;
using System.Reflection;

namespace MyBlog_IoTAutomation.DataAccessLayer.DBContexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Konut> Konutlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyBlogIoTAutomations;Trusted_Connection=True; Trust Server Certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("MyBlog-IoTAutomation.EntityLayer"));
        }
    }
}
