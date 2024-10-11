using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            this.capacidad = 100;
            this.cantidadActual = 0;
        }



        private string color, material;
        private int capacidad, cantidadActual;

        public string Color
        {
            get { return color; }
        }
        public string Material
        {
            get { return material; }
        }
        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        ///////////////////////////////////////////////  METODOS   /////////////////////////////////

        public string PresentarBotella()
        {
            return $"La botella es de color {color} esta fabricada de {material} y tiene una capacidad de {capacidad} ML";
        }

        public float CargarAgua()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = (dif * 50) / 100;
                cantidadActual +=  dif;

                return monto;
            }
            else
            {
                cantidadActual = 100;
                return 50;
            }

        }
        public float CargarAgua(int elegirCantidad)
        {
            if ((cantidadActual + elegirCantidad) <= capacidad)
            {
                float monto = (elegirCantidad * 50) / 100;
                cantidadActual += elegirCantidad;
                return monto;
            }
            else
                Console.WriteLine("No se puede cargar esa cantidad amigoo!");
                return -1;
        }

        public string TomarAgua()
        {
            if(cantidadActual >= 10)
            {
                cantidadActual -= 10;
                return $"Tomaste 10ml ahora queda... {cantidadActual}";
            }
            else if (cantidadActual >= 1 && cantidadActual < 10)
            {
                cantidadActual -= 1;
                return $"Te queda poca agua tomaste 1ml ahora queda... {cantidadActual}";

            }
            else
                return "Tu botella no tiene agua para que tomes... Ojala no estes en el desierto!";
        }
    }
}
