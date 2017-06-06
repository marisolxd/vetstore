using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class VeterinarioRepository : Repository<Veterinario>, IVeterinarioRepository
    {
        public VeterinarioRepository(VetstoreDbContext context):base(context)
		{
        }
    }
}
