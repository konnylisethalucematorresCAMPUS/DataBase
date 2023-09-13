using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class AreaUsuarioConfiguration : IEntityTypeConfiguration<AreaUsuario>
{
    public void Configure(EntityTypeBuilder<AreaUsuario> builder)
    {
        builder.ToTable("AreaUser");
    

                builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Area_User")
                .HasColumnType("int")
                .IsRequired();

                builder.HasOne(y => y.Persona)
                .WithMany(l => l.AreaUsuarios)
                .HasForeignKey(z => z.Id_Persona)
                .IsRequired();

                builder.HasOne(y => y.Area)
                .WithMany(l => l.AreaUsuarios)
                .HasForeignKey(z => z.Id_Area)
                .IsRequired();


          
    }
}