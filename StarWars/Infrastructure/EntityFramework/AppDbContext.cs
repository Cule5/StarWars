using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.CharacterData;
using Core.Domain.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Friendship> Friendships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=localhost;Database=StarWarsDataBase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friendship>()
                .HasOne(pt => pt.CharacterA)
                .WithMany(p => p.FriendshipsA) // <--
                .HasForeignKey(pt => pt.CharacterAId)
                .OnDelete(DeleteBehavior.Restrict); // see the note at the end

            modelBuilder.Entity<Friendship>()
                .HasOne(pt => pt.CharacterB)
                .WithMany(t => t.FriendshipsB)
                .HasForeignKey(pt => pt.CharacterBId);

        }
    }
}
