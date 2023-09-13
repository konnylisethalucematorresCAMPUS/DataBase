using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(ApiContext context) : base(context)
        {
        }
    }
}