using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Venta
    {
        private int codArticulo, cantidad, codCliente;

        public int CodArticulo
        {
            get { return codArticulo; }
            set { codArticulo = value; }

        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }


        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
    }
}
