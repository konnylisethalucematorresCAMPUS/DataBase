using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("TipoDocumento");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();
                    
            builder.Property(p => p.NombreTipoDocumento)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(p => p.AbreviaturaTipoDocumento)
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
    }
}