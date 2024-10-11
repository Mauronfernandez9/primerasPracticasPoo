using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCafetera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafeteraNueva = new Cafetera();

            //Console.WriteLine(cafeteraNueva.CantidadMax);

            Console.WriteLine(cafeteraNueva.LlenarCafetera());
            Console.WriteLine(cafeteraNueva.CantidadActual);
            Console.WriteLine(cafeteraNueva.PonerCafe(20));
            Console.WriteLine(cafeteraNueva.LlenarTaza(20));
            

            Console.WriteLine(cafeteraNueva.LlenarCafetera());
            Console.WriteLine(cafeteraNueva.CantidadActual);





            Console.ReadKey();
        }
    }
}
