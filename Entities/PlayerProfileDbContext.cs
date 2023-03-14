using Microsoft.EntityFrameworkCore;

namespace queueUp.Entities
{

    public class PlayerProfileDbContext : DbContext
    {
        private string _connectionString = "Server=.\\SQLExpress;Database=QueueUpDB;Trusted_Connection=Yes;";

        public DbSet<User> Users { get; set; }
        public DbSet<PlayerProfile> PlayerProfiles { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<Game>()
                .Property(g=>g.GameTitle)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    } 
}