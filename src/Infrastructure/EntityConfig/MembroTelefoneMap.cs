using AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class MembroTelefoneMap : IEntityTypeConfiguration<MembroTelefone>
    {
        public void Configure(EntityTypeBuilder<MembroTelefone> builder)
        {
            builder.Property(e => e.TipoTelefone)
               .HasColumnType("varchar(15)")
               .IsRequired();

            builder.Property(e => e.Numero)
                .HasColumnType("varchar(20)")
                .IsRequired();
        }
    }
}
