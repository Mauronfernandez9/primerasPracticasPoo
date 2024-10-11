using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Perro
    {
      private  string nombre, color, origen;

        public string Nombre
        {
            get  { return nombre; }
            set { nombre = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }

        }
        public string Origen
        {
            get { return origen;}
            set { origen = value; }
        }

    }
}
