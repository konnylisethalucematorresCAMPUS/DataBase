using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PerifericoConfiguration : IEntityTypeConfiguration<Periferico>
{
    public void Configure(EntityTypeBuilder<Periferico> builder)
    {
        builder.ToTable("Periferico");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();
                    
            builder.Property(p => p.NombrePeriferico)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
    }
}