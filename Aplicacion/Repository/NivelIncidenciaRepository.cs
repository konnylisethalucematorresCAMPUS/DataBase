using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Entities;
using Persistencia;

namespace Aplicacion.Repository;
public class NivelIncidenciaRepository : GenericRepository<NivelIncidencia>, INivelIncidenciaRepository
{
    public NivelIncidenciaRepository(ApiContext context) : base(context)
    {
        
    }
}