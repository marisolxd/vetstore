using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class CategoriaProductoRepository : Repository<CategoriaProducto> , ICategoriaProductoRepository
    {
        public CategoriaProductoRepository(VetstoreDbContext context):base(context)
		{
        }
    }
}
