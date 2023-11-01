using Microsoft.EntityFrameworkCore;
using SurrprizPaket.Models;

namespace SurrprizPaket.Repository
{
    public class BaseDbContext:DbContext
    {
        public BaseDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=SurprizPaketDb Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
