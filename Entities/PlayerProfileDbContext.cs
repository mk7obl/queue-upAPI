using Microsoft.EntityFrameworkCore;

namespace queueUp.Entities
{

    public class PlayerProfileDbContext : DbContext
    {
        private string _connectionString = "Server=.\\SQLExpress;Database=RestaurantDB;Trusted_Connection=Yes;";

        public DbSet<PlayerProfile> PlayerProfile { get; set; }
        public DbSet<Game> Game { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<Game>()
                .Property(g=>g.Title)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    } 
}