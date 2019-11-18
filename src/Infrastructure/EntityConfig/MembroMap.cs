using AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class MembroMap : IEntityTypeConfiguration<Membro>
    {
        public void Configure(EntityTypeBuilder<Membro> builder)
        {
            builder.Property(e => e.Nome)
            .HasColumnType("varchar(60)")
            .IsRequired();

            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.CNH)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(e => e.Profissao)
                .HasColumnType("varchar(30)");

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(30)");

            builder.Property(e => e.Cidade)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.UF)
                .HasColumnType("varchar(3)");

            builder.Property(e => e.CEP)
                .HasColumnType("varchar(10)");

            builder.HasMany(e => e.Telefones)
                .WithOne(e => e.Membro)
                .HasForeignKey(e => e.MembroId)
                .HasPrincipalKey(e => e.MembroId);

        }
    }
}
