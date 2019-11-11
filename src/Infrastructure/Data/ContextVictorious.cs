using AplicationCore.Entity;
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

            #region Configuracoes Membro

            modelBuilder.Entity<Membro>().Property(e => e.Nome)
                .HasColumnType("varchar(60)")
                .IsRequired();

            modelBuilder.Entity<Membro>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Membro>().Property(e => e.CNH)
                .HasColumnType("varchar(20)")
                .IsRequired();

            modelBuilder.Entity<Membro>().Property(e => e.Profissao)
                .HasColumnType("varchar(30)");

            modelBuilder.Entity<Membro>().Property(e => e.Logradouro)
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Membro>().Property(e => e.Bairro)
                .HasColumnType("varchar(30)");

            modelBuilder.Entity<Membro>().Property(e => e.Cidade)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Membro>().Property(e => e.UF)
                .("char(3)");

            modelBuilder.Entity<Membro>().Property(e => e.CEP)
                .HasColumnType("varchar(10)");

            #endregion

            #region Configuracoes MembroTelefone

            modelBuilder.Entity<MembroTelefone>().Property(e => e.TipoTelefone)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<MembroTelefone>().Property(e => e.Numero)
                .HasColumnType("varchar(20)")
                .IsRequired();

            #endregion

            #region Configuracoes Cargo

            modelBuilder.Entity<Cargo>().Property(e => e.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Cargo>().Property(e => e.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            #endregion
        }
    }
}
