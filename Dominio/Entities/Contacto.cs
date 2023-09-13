using System.ComponentModel.DataAnnotations;
using Dominio;

namespace Entities;

public class Contacto : BaseEntity
{
    public int Id_Persona { get; set; }
    public Persona ? Persona { get; set; }

    public int Id_TypeContact { get; set; }
    public TipoContacto ? TipoContacto { get; set; }

    public int Id_CategoryContact { get; set; }
    public CategoriaContacto ? CategoriaContacto { get; set; }

    public string ?Description_Contact { get; set; }
}