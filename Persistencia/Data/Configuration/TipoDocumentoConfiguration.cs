using Dominio;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("DocumentType");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_DocumentType")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Name_DocumentType)
            .HasColumnName("NameDocumentType")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();       



            builder.Property(p => p.Abbreviation_DocumentType)
            .HasColumnName("AbreviationDocumentTye")
            .HasColumnType("varchar")
            .HasMaxLength(10)
            .IsRequired();                    

    }
}