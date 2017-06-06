using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.Entities
{
    public class Veterinario
    {
        public int VeterinarioId { get; set; }
        public string Nomnbre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int CMVP { get; set; }
        public int Dni { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public List<ServicioAtencion> ServicioAtenciones { get; set; }

        public Veterinario()
        {
            ServicioAtenciones = new List<ServicioAtencion>();
        }
    }
}
