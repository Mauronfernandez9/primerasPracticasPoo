using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella botellaNueva = new Botella("Roja","Plastico");

            Botella botella2 = new Botella("Verde", "Metal");

            Botella botella3 = new Botella("Purpura", "Metal");


            string pepe = "PEpito";
            Console.WriteLine(pepe.Replace("PE", "pa"));



            Console.WriteLine($"Objeto 1: {botellaNueva.GetHashCode()}");
            Console.WriteLine($"Objeto 2: {botella2.GetHashCode()}");
            Console.WriteLine($"Objeto 3: {botella3.GetHashCode()}");

            // Console.WriteLine(botellaNueva.CargarAgua(25));

            // Console.WriteLine(botellaNueva.CantidadActual);


            //Console.WriteLine( botellaNueva.TomarAgua());
            //Console.WriteLine(botellaNueva.TomarAgua());
            //Console.WriteLine(botellaNueva.TomarAgua());
            // Console.WriteLine(botellaNueva.TomarAgua());
            // Console.WriteLine(botellaNueva.TomarAgua());
            //Console.WriteLine(botellaNueva.TomarAgua());
            //Console.WriteLine(botellaNueva.TomarAgua());
            // Console.WriteLine(botellaNueva.TomarAgua());





        }
    }
}
