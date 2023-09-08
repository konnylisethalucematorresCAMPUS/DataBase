using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class NivelIncidenciaConfiguration : IEntityTypeConfiguration<NivelIncidencia>
{
    public void Configure(EntityTypeBuilder<NivelIncidencia> builder)
    {
        builder.ToTable("NivelIncidencia");

                builder.Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();
                        
                builder.Property(p => p.NombreNivelIncidencia)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.Property(p => p.DescripcionNivelIncidencia)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
    }
}