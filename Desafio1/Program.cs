using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono nuevoTel = new Telefono("A-31", "Samsung");

            nuevoTel.NumeroTelefonico = "381-111-222";
            nuevoTel.CodigoOperador = 2;

            Console.WriteLine($"Estado del telefono\nModelo:{nuevoTel.Modelo}\nMarca:{nuevoTel.Marca}\nNúmero de telefono:{nuevoTel.NumeroTelefonico}\nCodigo Operador:{nuevoTel.CodigoOperador}");

            Console.WriteLine(nuevoTel.Llamar("Roberto el gordo"));
            Console.WriteLine(nuevoTel.Credito);
            Console.WriteLine(nuevoTel.CargarCredito(50));
            Console.WriteLine(nuevoTel.Credito);
            Console.WriteLine(nuevoTel.Llamar());
            Console.WriteLine(nuevoTel.Credito);






            Console.ReadKey();

        }
    }
}
