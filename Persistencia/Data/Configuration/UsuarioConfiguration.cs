using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

    
            builder.ToTable("usuario");

                builder.Property(p => p.Id)
                .HasColumnType("int")
                .IsRequired();
                        
                builder.Property(p => p.Username)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
                        
                builder.HasIndex(p => new {
                    p.Username,
                    p.Email
                }).HasDatabaseName("IX_MiIndice")
                .IsUnique();

                builder.Property(p => p.Email)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder
                .HasMany(p => p.Roles)
                .WithMany(p => p.Usuarios)
                .UsingEntity<UsuariosRoles>(
                    j => j
                        .HasOne(pt => pt.Rol)
                        .WithMany(t => t.UsuariosRoles)
                        .HasForeignKey(pt => pt.IdRol),
                    j => j
                        .HasOne(pt => pt.Usuario)
                        .WithMany(p => p.UsuariosRoles)
                        .HasForeignKey(pt => pt.IdUsuario),
                    j =>
                    {
                        j.HasKey(t => new { t.IdUsuario, t.IdRol });
                    });

        }
    }
}