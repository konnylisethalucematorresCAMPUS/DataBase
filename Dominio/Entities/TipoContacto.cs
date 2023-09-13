using Entities;

namespace Dominio;

public class TipoContacto : BaseEntity
{
  
    public string ?Name_Contact { get; set; }
    public ICollection<Contacto> ? Contactos  { get; set; }
    public string ?Description_ContactType { get; set; }
}