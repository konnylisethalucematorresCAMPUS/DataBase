using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class DireccionRepository : GenericRepository<Direccion>, IDireccionRepository
{
    public DireccionRepository(ApiContext context) : base(context)
    {
        
    }
}