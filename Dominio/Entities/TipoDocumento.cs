using Dominio;

namespace Entities;

public class TipoDocumento : BaseEntity
{
    public string ?Name_DocumentType { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
    public Contacto ? Contacto { get; set; }
    public string ?Abbreviation_DocumentType { get; set; }
}