using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class ServicioAtencionRepository: Repository<ServicioAtencion>, IServicioAtencionRepository
    {
        public ServicioAtencionRepository(VetstoreDbContext context):base(context)
		{
        }
    }
}
