using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class CategoriaContactoConfiguration : IEntityTypeConfiguration<CategoriaContacto>
{
    public void Configure(EntityTypeBuilder<CategoriaContacto> builder)
    {
        builder.ToTable("CategoryContact");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_CategoryContact")
            .HasColumnType("int")
            .IsRequired();



            builder.Property(p => p.Id_Category)
            .HasColumnName("Id_Category")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Name_CategoryContact)
            .HasColumnName("Name_CategoryContact")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

         }
}