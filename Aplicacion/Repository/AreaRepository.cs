using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository;
public class AreaRepository : GenericRepository<Area>, IAreaRepository
{
    public AreaRepository(ApiContext context) : base(context)
    {
        
    }
}