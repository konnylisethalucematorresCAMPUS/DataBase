using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPaisRepository
{
    public PaisRepository(ApiContext context) : base(context)
    {
    }
}
