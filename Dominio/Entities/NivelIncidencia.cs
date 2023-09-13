using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class NivelIncidencia : BaseEntity
{
    public string ?Name_LevelIncidence { get; set; }
    public ICollection<DetalleIncidencia> ?DetalleIncidencia { get; set; }
    public string ?Description_LevelIncidence { get; set; }
}