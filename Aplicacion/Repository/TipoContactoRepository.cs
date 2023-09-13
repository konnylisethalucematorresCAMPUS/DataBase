using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TipoContactoRepository : GenericRepository<TipoContacto>, ITipoContactoRepository
    {
        public TipoContactoRepository(ApiContext context) : base(context)
        {
        }
    }
}