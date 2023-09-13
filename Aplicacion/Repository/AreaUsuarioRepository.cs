using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class AreaUsuarioRepository : GenericRepository<AreaUsuario>, IAreaUsuarioRepository
    { 
        public AreaUsuarioRepository(ApiContext context) : base(context)
        {
            
        }
    }
}