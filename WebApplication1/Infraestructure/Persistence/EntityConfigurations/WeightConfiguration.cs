using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain;

namespace WebApplication1.Infraestructure.Persistence.EntityConfigurations
{
    public class WeightConfiguration : IEntityTypeConfiguration<Weight>
    {
        public void Configure(EntityTypeBuilder<Weight> builder)
        {
            builder
                .ToTable("Weigths")
                .HasKey(ej => ej.Id);
            
            builder
                .Property(ej => ej.Id)
                .ValueGeneratedNever();

            builder
                .Property(ej => ej.Date)
                .HasColumnType("timestamp")
                .IsRequired();

            builder
                .Property(ej => ej.Peso)
                .HasColumnType("FLOAT8")
                .IsRequired();

            builder
                .Property(ej => ej.IsOfJavi)
                .IsRequired();

            builder
                .Property(ej => ej.IsMoreRecent)
                .IsRequired();

            builder
                .Property(peso => peso.EjercicioId)
                .IsRequired();
            builder
                .HasOne(peso => peso.Ejercicio)
                .WithMany(ej => ej.Weights)
                .HasForeignKey(peso => peso.EjercicioId);
            
        }
    }
}