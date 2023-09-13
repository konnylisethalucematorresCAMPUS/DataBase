using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class EstadoRepository : GenericRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(ApiContext context) : base(context)
        {
        }
    }
}