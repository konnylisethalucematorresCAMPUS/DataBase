using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class ContactoRepository : GenericRepository<Contacto>, IContactoRepository
    {
        public ContactoRepository(ApiContext context) : base(context)
        {
        }
    }
}