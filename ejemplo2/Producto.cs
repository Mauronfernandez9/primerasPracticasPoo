using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Producto
    {

        private int codProducto, codMarca;
        private float precio;

        public int CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }

        }

        public int CodMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
