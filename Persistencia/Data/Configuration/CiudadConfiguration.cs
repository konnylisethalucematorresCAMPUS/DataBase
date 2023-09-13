using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class CityConfiguration : IEntityTypeConfiguration<Ciudad>
    {
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("cities");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_City")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NameCity)
                .HasColumnName("NameCity")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.HasOne(p => p.Region)
                .WithMany(p => p.Ciudades)
                .HasForeignKey(p => p.Id_Region);
    }
}