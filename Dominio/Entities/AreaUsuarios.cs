using Dominio;

namespace Entities;
public class AreaUsuario : BaseEntity
{
    
    public int Id_Area { get; set; }
    public Area ? Area { get; set; }
    public int Id_Persona { get; set; }
    public Persona ? Persona { get; set; }
}