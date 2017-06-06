using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.Entities
{
    public class CategoriaProducto
    {
        public int CategoriaProductoId { get; set; }

        public List<Producto> Productos { get; set; }


        public CategoriaProducto()
        {
            Productos = new List<Producto>();

        }

    }
}
