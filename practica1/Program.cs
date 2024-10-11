using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Perro perro1 = new Perro();

            //perro1.Nombre = "Roberto";
            //perro1.Color = "Purpura";
            //perro1.Origen = "Transilvania";

            //Console.WriteLine($"El perro {perro1.Nombre} es de color {perro1.Color} y nacio en {perro1.Origen}");

            //Articulo art1 = new Articulo();
            //Articulo art2 = new Articulo();
            //Articulo art3 = new Articulo();

            //Articulo[] vectorArticulos = new Articulo[3] {art1,art2,art3};


            //for(int x=0; x<3; x++)
            //{
            //    Console.WriteLine($"Ingresa un codigo para el articulo {x + 1}");
            //    vectorArticulos[x].Codigo = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Ingresa el precio del articulo {x + 1}");
            //    vectorArticulos[x].Precio = float.Parse(Console.ReadLine());

            //    Console.WriteLine($"Ingresa la cantidad de stock para el articulo {x+1}");
            //    vectorArticulos[x].Stock = int.Parse(Console.ReadLine());
            //}

            //for(int y=0; y < 3; y++)
            //{
            //    Console.WriteLine($"El articulo{y + 1}: {vectorArticulos[y].Codigo} /// ${vectorArticulos[y].Precio}///${vectorArticulos[y].Stock}");

            //}

            Venta venta1= new Venta();
            Venta venta2 = new Venta();
            Venta venta3 = new Venta();
            Venta venta4 = new Venta();
            Venta venta5 = new Venta();

            Venta[] ventas = new Venta[5] { venta1, venta2, venta3, venta4, venta5 };

            for(int x=0; x < 5; x++)
            {
                Console.WriteLine("¿Que articulo fue vendido?: ");
                ventas[x].CodigoArticulo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("¿Ingresa el codigo del cliente?");
                ventas[x].CodCliente = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Cual fue la cantidad vendida?: ");
                ventas[x].Cantidad = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"El articulo #{ventas[i].CodigoArticulo} se vendio {ventas[i].Cantidad} veces al número de cliente: {ventas[i].CodCliente}");          
            }







            Console.ReadKey();
        }
    }
}
