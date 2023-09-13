using System.ComponentModel.DataAnnotations;

using Dominio;

namespace Entities;
public class CategoriaContacto : BaseEntity
{
    public Contacto ? Contacto { get; set; }
    public int Id_Category { get; set; }
    public string ?Name_CategoryContact { get; set; }
     public ICollection<Contacto> ? Contactos { get; set; }
}