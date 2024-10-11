using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Venta
    {
        private int codigoArticulo, cantidad, codCliente;

        public int CodigoArticulo
        {
            get {return codigoArticulo; }
            set { codigoArticulo = value; }
        }

        public int Cantidad 
        {
            get { return cantidad;}
            set { cantidad = value;}
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }

        }

    }
}
