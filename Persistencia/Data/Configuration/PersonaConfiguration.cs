using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Person");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("Id_User")
        .HasColumnType("int")
        .IsRequired();


        builder.Property(p => p.Name)
        .HasColumnName("Name")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();


        builder.Property(p => p.Lastname)
       .HasColumnName("lastname")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.Id_DocumentType)
        .HasColumnName("document_type")
        .HasColumnType("int")
        .IsRequired();



        builder.HasOne(u => u.TipoDocumento)
        .WithMany(a => a.Personas)
        .HasForeignKey(u => u.Id_DocumentType)
        .IsRequired();

    }
}