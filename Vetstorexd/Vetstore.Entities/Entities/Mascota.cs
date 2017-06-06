using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.Entities
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public char Sexo { get; set; }
        public string Color { get; set; }
        public double Peso { get; set; }
        public int Edad { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
