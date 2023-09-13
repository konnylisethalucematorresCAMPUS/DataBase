using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class Incidencia : BaseEntity
{ 
    public int Id_Persona { get; set; }
    public Persona ? Persona { get; set; }

    public int Id_State { get; set; }
    public Estado ? Estado { get; set; }

    public int Id_Area { get; set; }
     public Area ? Area { get; set; }


    public int Id_Place { get; set; }
    public Lugar ? Lugar { get; set; }

    public DateTime Date { get; set; }
    public string ?Description_Incidence { get; set; }

    public string ?Detail_Incidence { get; set; }
    public ICollection<DetalleIncidencia> ? DetalleIncidencia  { get; set; }

}