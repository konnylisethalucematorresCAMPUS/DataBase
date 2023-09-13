using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace persistencia.Configuration;
public class PlaceConfiguration : IEntityTypeConfiguration<Lugar>
{
    public void Configure(EntityTypeBuilder<Lugar> builder)
    {
        builder.ToTable("Place");

                builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Place")
                .HasColumnType("int")
                .IsRequired();


                builder.Property(p => p.Name_Place)
                .HasColumnName("NamePlace")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

                builder.Property(p => p.Description_Place)
                .HasColumnName("DescriptionPlace")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();







                builder.HasOne(y => y.Area)
                .WithMany(l => l.Places)
                .HasForeignKey(z => z.Id_AreaOrigin)
                .IsRequired();
    }
}