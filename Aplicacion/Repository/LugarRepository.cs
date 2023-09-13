using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class LugarRepository : GenericRepository<Lugar>, ILugarRepository
    {
        public LugarRepository(ApiContext context) : base(context)
        {
        }
    }
}