using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("rol");

                builder.Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();
                        
                builder.Property(p => p.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

                builder.Property(p => p.DescripcionRol)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
    }
}