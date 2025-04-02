using Microsoft.EntityFrameworkCore;
using ProductManagementApp.Models;

namespace ProductManagementApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
