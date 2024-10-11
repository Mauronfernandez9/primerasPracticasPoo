using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Articulo
    {
        private int codigo,stock;
        private float precio;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


    }
}
