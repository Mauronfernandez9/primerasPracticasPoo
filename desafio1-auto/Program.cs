using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1_auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos = new Auto[3];

            for (int x = 0; x < 3; x++)
            {
                Console.Write("Ingresa la marca del coche: ");
                string cocheMarca = Console.ReadLine();
                Console.Write("Ingresa el modelo del coche: ");
                string cocheModelo = Console.ReadLine();
                Console.Write("Ingresa su año de fabricacion: ");
                int cocheAnio = int.Parse(Console.ReadLine());
                Console.Write("Ingresa su color: ");
                string cocheColor = Console.ReadLine();

                autos[x] = new Auto(cocheMarca,cocheModelo,cocheColor,cocheAnio);

            }

            for(int y = 0; y < 3; y++)
            {
                Console.WriteLine(autos[y].Estado());
            }
            Console.ReadKey();
        }
    }
}
