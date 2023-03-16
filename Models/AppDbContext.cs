using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace urlopy2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        public DbSet<Pracownik> Pracownicy { get; set; }
    }
}
