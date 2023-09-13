using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository
{
    public class DetalleIncidenciaRepository : GenericRepository<DetalleIncidencia>, IDetalleIncidenciaRepository
    {
        public DetalleIncidenciaRepository(ApiContext context) : base(context)
        {
        }
    }
}