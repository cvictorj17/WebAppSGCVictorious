using AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfig
{
    public class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            
            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
