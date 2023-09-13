using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class TipoIncidencia : BaseEntity
{
    public ICollection<DetalleIncidencia> ?DetalleIncidencias { get; set; }
    public string ?Name_TypeIncidence { get; set; }
    public string ?Description_TypeIncidence { get; set; }

}