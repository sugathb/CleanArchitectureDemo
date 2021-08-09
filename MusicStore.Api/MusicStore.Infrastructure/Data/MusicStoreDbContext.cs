using Microsoft.EntityFrameworkCore;
using MusicStore.Domain;

namespace MusicStore.Infrastructure.Data
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.ArtistId);
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.AlbumId);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreId);
            });
        }
    }
}
