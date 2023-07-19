using ayniyatv1.Models;
using Microsoft.EntityFrameworkCore;

namespace ayniyatv1.Data
{
    public class AppDbContext:DbContext
    {
  

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
              
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}
