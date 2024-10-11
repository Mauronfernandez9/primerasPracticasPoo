using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCafetera
{
    internal class Cafetera
    {
        public Cafetera()
        {
            this.cantidadMax = 1000;
            cantidadActual = 0;
            cantidadCafe = 0;
        }
        private int cantidadMax;
        private int cantidadActual;
        private int cantidadCafe;

        /////////////////////// PSEUDO METODOS ////////////////////////////////////

        public int CantidadMax
        {
            get { return cantidadMax; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        public int CantidadCafe
        {
            get { return cantidadCafe; }
        }



        public string LlenarCafetera()
        {
            if (cantidadActual < cantidadMax && cantidadCafe == 0)
            {
                cantidadActual = 1000;
                return "Cafetera llena ...";

            }
            else if(cantidadCafe >0 && cantidadCafe < 1000)
            {
                cantidadCafe = 1000;
                return "Se agrego mas agua al cafe... El cafe estara más suave ahora...";
            }
            else
                return "Ya esta llena la cafetera...";
        }

        public string LlenarCafetera(int cantidad)
        {
            if ((cantidad + cantidadActual) <= 1000)
            {
                cantidadActual += cantidad;
                return $"A la cafetera se le agrego {cantidad}ml de agua ahora tiene en su interior {cantidadActual}ml de agua";
            }
            else
            {
                return "No se puede llenar esa cantidad la cafetera...";
            }
        }

        public string PonerCafe(int cantCafe)
        {
            if (cantidadActual > 0 && cantCafe <= cantidadActual)
            {
                cantidadCafe = cantidadActual;
                cantidadActual = 0;
                return $"Tu cafetera tiene {cantidadCafe}ml de cafe";

            }
            else
            {
                return "No hay suficiente agua para agregar cafe...";
            }

        }

        public string VaciarCafetera()
        {
            if (cantidadActual > 0 || cantidadCafe > 0)
            {
                cantidadActual = 0;
                cantidadCafe = 0;
                return "Cafetera vacia...";
            }
            else
                return "No puedes vaciar la cafetera porque ya esta vacia...";
        }

        public string LlenarTaza(int capacTaza)
        {
            if ((cantidadActual - capacTaza) >= 0)
            {
                cantidadActual -= capacTaza;
                return $"Se lleno la taza pero con agua... Ahora hay {cantidadActual}ml de agua en la cafetera";
            }
            else if ((cantidadCafe - capacTaza) >= 0)
            {
                cantidadCafe -= capacTaza;
                return $"Se lleno la taza con cafe... Ahora hay {cantidadCafe}ml de cafe en la cafetera";
            }
            else
            {
                return "No se puede cargar la taza porque no hay mas agua";
            }

        }


    }
}
