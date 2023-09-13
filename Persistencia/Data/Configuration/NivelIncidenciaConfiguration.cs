using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;

public class LevelIncidenceConfiguration : IEntityTypeConfiguration<NivelIncidencia> 
{   
    public void Configure(EntityTypeBuilder<NivelIncidencia> builder)
    {
        builder.ToTable("LevelIncidence");
      



            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_LevelIncidence")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Name_LevelIncidence)
            .HasColumnName("Name_LevelIncidence")
            .HasColumnType("varchar")
            .HasMaxLength(80)
            .IsRequired();


            builder.Property(p => p.Description_LevelIncidence)
            .HasColumnName("Description_LevelIcidence")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();
    }
}