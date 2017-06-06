using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public int Direccion { get; set; }
        public string Correo { get; set; }

        public List<ServicioAtencion> ServicioAtenciones { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente()
        {
            ServicioAtenciones = new List<ServicioAtencion>();
            Mascotas = new List<Mascota>();
        }
    }
}
