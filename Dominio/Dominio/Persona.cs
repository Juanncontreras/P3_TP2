using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Dni { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }

        public int Edad { get; set; }

       public int Cuil { get; set; }

    }
}
