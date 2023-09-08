using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class LugarConfiguration : IEntityTypeConfiguration<Lugar>
{
    public void Configure(EntityTypeBuilder<Lugar> builder)
    {
        builder.ToTable("Lugar");

                builder.Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();

                builder.Property(p => p.NombreLugar)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
                        
                builder.Property(p => p.DescripcionLugar)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
    }
}