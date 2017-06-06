using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Enums;

namespace Vetstore.Entities.Entities
{
    public class ServicioAtencion
    {
        public int ServicioAtencionId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int VeterinarioId { get; set; }
        public Veterinario Veterinario { get; set; }

        public ServicioEstetico ServicioEstetico { get; set; }
        public ServicioClinico ServicioClinico { get; set; }
        public ServicioHospedaje ServicioHospedaje { get; set; }
        public ServicioRecreativo ServicioRecreativo { get; set; }

        public List<Venta> Ventas { get; set; }

        public ServicioAtencion()
        {
            Ventas = new List<Venta>();
        }
    }
}
