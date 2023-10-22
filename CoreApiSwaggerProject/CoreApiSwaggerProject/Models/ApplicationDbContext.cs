using Microsoft.EntityFrameworkCore;

namespace CoreApiSwaggerProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
       
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Bayi> Bayis { get; set; }


    }
}
