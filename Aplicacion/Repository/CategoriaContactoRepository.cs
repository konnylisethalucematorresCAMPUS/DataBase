using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class CategoriaContactoRepository : GenericRepository<CategoriaContacto>, ICategoriaContactoRepository
    {
        public CategoriaContactoRepository(ApiContext context) : base(context)
        {
        }
    }
}