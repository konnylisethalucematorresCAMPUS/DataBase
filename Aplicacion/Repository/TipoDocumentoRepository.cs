using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TipoDocumentoRepository : GenericRepository<TipoDocumento>, ITipoDocumentoRepository
    {
        public TipoDocumentoRepository(ApiContext context) : base(context)
        {
        }
    }
}
