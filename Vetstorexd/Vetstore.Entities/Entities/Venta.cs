using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Enums;

namespace Vetstore.Entities.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime VentaDay { get; set; }
        public List<Producto> Productos { get; set; }

        public int ServicioAtencionId { get; set; }
        public ServicioAtencion ServicioAtencion { get; set; }

        public TipoPago TipoPago { get; set; }

        public Venta()
        {
            Productos = new List<Producto>();
        }
    }
}
