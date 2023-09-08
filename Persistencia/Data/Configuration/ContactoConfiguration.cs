using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
{
    public void Configure(EntityTypeBuilder<Contacto> builder)
    {
        builder.ToTable("Contacto");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.DescripcionContacto)
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        
            builder.HasOne(y => y.Persona)
            .WithMany(l => l.Contactos)
            .HasForeignKey(z => z.IdPersona)
            .IsRequired();

            builder.HasOne(y => y.TipoContacto)
            .WithMany(l => l.Contactos)
            .HasForeignKey(z => z.IdTipoContacto)
            .IsRequired();

            builder.HasOne(y => y.CategoriaContacto)
            .WithMany(l => l.Contactos)
            .HasForeignKey(z => z.IdCategoriaContacto)
            .IsRequired();
    }
}