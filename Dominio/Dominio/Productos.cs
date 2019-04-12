using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Productos
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public int stock { get; set; }

        public int IdCompartimiento { get; set; }

        public DateTime VTO { get; set; }



    }
}
