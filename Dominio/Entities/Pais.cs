namespace Dominio;

public class Pais : BaseEntity
{
    public ICollection<Region> ?Regiones { get; set; }
    public string ? NameCountry { get; set; }
}