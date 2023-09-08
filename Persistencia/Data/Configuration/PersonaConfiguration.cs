using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {

            builder.ToTable("Persona");

                builder.Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();
                        
                builder.Property(p => p.NombrePersona)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.Property(p => p.ApellidoPersona)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.Property(p => p.DireccionPersona)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.HasOne(y => y.TipoDocumento)
                .WithMany(l => l.Personas)
                .HasForeignKey(z => z.IdTipoDocumento)
                .IsRequired();
        }
    }
}