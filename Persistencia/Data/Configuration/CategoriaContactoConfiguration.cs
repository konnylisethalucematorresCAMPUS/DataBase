using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CategoriaContactoConfiguration : IEntityTypeConfiguration<CategoriaContacto>
{
    public void Configure(EntityTypeBuilder<CategoriaContacto> builder)
    {
        builder.ToTable("CategoriaContacto");
        
            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.NombreCategoriaContacto)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
    }
}