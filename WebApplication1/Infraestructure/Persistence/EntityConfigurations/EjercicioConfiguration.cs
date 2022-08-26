using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain;

namespace WebApplication1.Infraestructure.Persistence.EntityConfigurations
{
    public class EjercicioConfiguration : IEntityTypeConfiguration<Ejercicio>
    {
        public void Configure(EntityTypeBuilder<Ejercicio> builder)
        {
            builder
                .ToTable("Ejercicio")
                .HasKey(ej => ej.Id);
            
            builder
                .Property(ej => ej.Id)
                .ValueGeneratedNever();

            builder
                .Property(ej => ej.Category)
                .HasColumnType("INTEGER")
                .IsRequired();

            builder
                .Property(ej => ej.Name)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder
                .Property(ej => ej.IsActive)
                .IsRequired();

            builder
                .Property(ej => ej.IsDone)
                .IsRequired();
            
            
            
        }
    }
}