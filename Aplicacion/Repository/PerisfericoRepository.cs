using Dominio;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class PerisfericoRepository : GenericRepository<Perisferico>, IPerisfericoRepository
    {
        public PerisfericoRepository(ApiContext context) : base(context)
        {
        }
    }
}