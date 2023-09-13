namespace Dominio;

public class Region : BaseEntity
{
    public ICollection<Ciudad> ? Ciudades { get; set; }

    public string? NameRegion { get; set; }
    public int Id_Pais { get; set; }
    public Pais ? Pais { get; set; }
}