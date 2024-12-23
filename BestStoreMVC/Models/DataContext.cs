using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base() 
        { }
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        public DbSet<products> products { get; set; }
    }
}
