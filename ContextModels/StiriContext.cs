using Microsoft.EntityFrameworkCore;

namespace WebApplication1.ContextModels
{
    public class StiriContext : DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options) : base(options) { }

        public StiriContext() { }

        public DbSet<Stire> Stiri { get; set; }
        public DbSet<Categorie> Categorii { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Stiri;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
