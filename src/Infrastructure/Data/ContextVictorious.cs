using AplicationCore.Entity;
using Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ContextVictorious: DbContext
    {
        public ContextVictorious(DbContextOptions<ContextVictorious> options) : base(options)
        {

        }

        public DbSet<Membro> Membros { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<MembroTelefone> MembroTelefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membro>().ToTable("tbMembro");
            modelBuilder.Entity<Cargo>().ToTable("tbCargo");
            modelBuilder.Entity<MembroTelefone>().ToTable("tbMembroTelefone");

            modelBuilder.ApplyConfiguration(new MembroMap());
            modelBuilder.ApplyConfiguration(new MembroTelefoneMap());
            modelBuilder.ApplyConfiguration(new CargoMap());

        }
    }
}
