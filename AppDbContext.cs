using Microsoft.EntityFrameworkCore;
using React_Ecommerce_BE.Models;

namespace React_Ecommerce_BE
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure your database provider here
                optionsBuilder.UseSqlServer("server=ANUKEERTHANA\\SQLEXPRESS02;database=ecommerce;Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=True");
            }
        }

        public DbSet<Product> Products { get; set; }
    }
}
