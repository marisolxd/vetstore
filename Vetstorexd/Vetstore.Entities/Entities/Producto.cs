using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Enums;

namespace Vetstore.Entities.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }

        public int CategoriaProductoId { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
