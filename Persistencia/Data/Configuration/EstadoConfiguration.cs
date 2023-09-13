using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace persistencia.Configuration;
public class StateConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("State");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_State")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Description_State)
            .HasColumnName("Description_State")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
        }
}