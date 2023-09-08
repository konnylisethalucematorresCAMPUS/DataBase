using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class IncidenciaConfiguration : IEntityTypeConfiguration<Incidencia>
{
    public void Configure(EntityTypeBuilder<Incidencia> builder)
    {
        builder.ToTable("Incidencia");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();
                    
            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .IsRequired();

            builder.Property(p => p.DescripcionIncidencia)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.HasOne(y => y.Persona)
            .WithMany(l => l.Incidencias)
            .HasForeignKey(z => z.IdPersona)
            .IsRequired();

            builder.HasOne(y => y.Estado)
            .WithMany(l => l.Incidencias)
            .HasForeignKey(z => z.IdEstado)
            .IsRequired();

            builder.HasOne(y => y.Area)
            .WithMany(l => l.Incidencias)
            .HasForeignKey(z => z.IdArea)
            .IsRequired();

            builder.HasOne(y => y.Lugar)
            .WithMany(l => l.Incidencias)
            .HasForeignKey(z => z.IdLugar)
            .IsRequired();
    }
}