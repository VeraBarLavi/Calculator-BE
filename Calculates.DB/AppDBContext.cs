using Microsoft.EntityFrameworkCore;

namespace Calculates.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Calculate> Calculates { get; set; }
        //TODO: MANAGE DATA PER USER!!!!
        //public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=CalculatesDB;Integrated Security=True");
        }
    }
}
