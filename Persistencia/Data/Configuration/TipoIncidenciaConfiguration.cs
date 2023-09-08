using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoIncidenciaConfiguration : IEntityTypeConfiguration<TipoIncidencia>
{
    public void Configure(EntityTypeBuilder<TipoIncidencia> builder)
    {
        builder.ToTable("TipoIncidencia");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();
                    
            builder.Property(p => p.NombreTipoIncidencia)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(p => p.DescripcionTipoIncidencia)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
    }
}