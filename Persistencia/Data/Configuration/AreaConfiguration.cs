using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.ToTable("Area");

            builder.Property(p => p.Id)
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.NombreArea)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
            

            builder.Property(p => p.DescripcionArea)
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
            

            builder
                .HasMany(p => p.Personas)
                .WithMany(p => p.Areas)
                .UsingEntity<AreaPersona>(
                    j => j
                        .HasOne(pt => pt.Persona)
                        .WithMany(t => t.AreaPersonas)
                        .HasForeignKey(pt => pt.IdPersona),
                    j => j
                        .HasOne(pt => pt.Area)
                        .WithMany(p => p.AreaPersonas)
                        .HasForeignKey(pt => pt.IdArea),
                    j =>
                    {
                        j.HasKey(t => new { t.IdArea, t.IdPersona });
                    });
    }
}