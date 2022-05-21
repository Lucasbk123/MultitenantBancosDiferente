using Microsoft.EntityFrameworkCore;
using Multitenant.Models;

namespace Multitenant.Data
{
    public class MultitenantContext : DbContext
    {
        public MultitenantContext(DbContextOptions<MultitenantContext> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasData(
                  new Pessoa { Id = 1, Nome = "Pessoa 1" },
                  new Pessoa { Id = 2, Nome = "Pessoa 2" },
                  new Pessoa { Id = 3, Nome = "Pessoa 3" });
        }
    }
}
