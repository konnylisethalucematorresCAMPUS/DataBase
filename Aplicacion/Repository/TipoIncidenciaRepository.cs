using Dominio;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TipoIncidenciaRepository : GenericRepository<TipoIncidencia>, ITipoIncidenciaRepository
    {
        public TipoIncidenciaRepository(ApiContext context) : base(context)
        {
        }
    }
}