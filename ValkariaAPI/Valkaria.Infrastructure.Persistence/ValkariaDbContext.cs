using Microsoft.EntityFrameworkCore;
using Valkaria.Core.Entities;

namespace Valkaria.Infrastructure.Persistence
{
    public class ValkariaDbContext : DbContext
    {
        public ValkariaDbContext(DbContextOptions<ValkariaDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<UserParty> UserParties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Parties)
                .WithOne()
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Party>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Party>()
                .HasMany(x => x.PartyMembers)
                .WithOne()
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserParty>()
                .HasKey(x => x.Id);

        }
    }
}
