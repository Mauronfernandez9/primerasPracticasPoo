using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1_auto
{
    internal class Auto
    {
        public Auto(string marca, string modelo, string color, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Año = año;
        }

        public string Marca { get; }
        public string Modelo { get; }
        public string Color { get; }
        public int Año { get; }

        private int velocidadActual = 0;
        private int velocidadLimite = 240;

        ///////////////////////////////////////////////////METODOS//////////////////////////////////////////////////////////

        public int acelerar(int incremento)
        {
            if ((velocidadActual + incremento) < velocidadLimite)
            {
                velocidadActual += incremento;
                return velocidadActual;
            }
            else
                return -1;
        }
        public int Frenar(int disminuir)
        {
            if ((velocidadActual - disminuir) >= 0)
            {
                velocidadActual -= disminuir;
                return velocidadActual;

            }
            else
                return -1;

        }

        public string Estado()
        {
            return $"-----------------------------------------\nInformacion del auto\nMarca:{Marca}\nModelo:{Modelo}\nAño:{Año}\nColor:{Color}";
        }



    }
}
