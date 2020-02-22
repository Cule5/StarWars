using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Character;
using Core.Domain.Episode;
using Core.Domain.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=localhost;Database=StarWarsDataBase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
}
