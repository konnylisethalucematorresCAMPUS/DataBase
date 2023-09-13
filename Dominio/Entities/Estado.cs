using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class Estado : BaseEntity
{
    public ICollection<DetalleIncidencia> ?DetalleIncidencias { get; set; }
    public DetalleIncidencia ? DetalleIncidencia { get; set; }
    public ICollection<Incidencia> ? Incidencias { get; set; }
    public string ?Description_State { get; set; }
}