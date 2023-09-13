using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;
public class Perisferico : BaseEntity
{
    public DetalleIncidencia ? DetalleIncidencia { get; set; }
    public string ?Name_Peripheral { get; set; }
}