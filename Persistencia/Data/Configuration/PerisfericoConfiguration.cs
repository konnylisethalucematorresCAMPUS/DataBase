using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;

public class PerisfericoConfiguration : IEntityTypeConfiguration<Perisferico>
{
    public void Configure(EntityTypeBuilder<Perisferico> builder)
    {
        builder.ToTable("Peripheral");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Peripheral")
            .HasColumnType("int")
            .IsRequired();



            builder.Property(p => p.Name_Peripheral)
            .HasColumnName("NamenePeripheral")
            .HasColumnType("varchar")
            .HasMaxLength(120)
            .IsRequired();



            builder.HasOne(y => y.DetalleIncidencia)
            .WithMany(l => l.Perisfericos)
            .HasForeignKey(z => z.Id)
            .IsRequired();
    }
}