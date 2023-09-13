using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class IncidenciaRepository : GenericRepository<Incidencia>, IIncidenciaRepository
    {
        public IncidenciaRepository(ApiContext context) : base(context)
        {
        }
    }
}