using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Models;

namespace OgrenciBilgiSistemi.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
    }
}