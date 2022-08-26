using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain;

namespace WebApplication1.Infraestructure.Persistence.EntityConfigurations
{
    public class DiaConfiguration : IEntityTypeConfiguration<Dia>
    {
        public void Configure(EntityTypeBuilder<Dia> builder)
        {
            builder
                .ToTable("Dias")
                .HasKey(dia => dia.Type);
            

            builder
                .Property(dia => dia.Type)
                .HasColumnType("INTEGER")
                .IsRequired();

            builder
                .Property(dia => dia.Name)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder
                .Property(dia => dia.IsFinished)
                .IsRequired();
        }
    }
}