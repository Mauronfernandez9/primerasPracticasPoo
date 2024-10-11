using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos = new Producto[3];
            Console.WriteLine("Registro de productos:");

            for (int x=0; x < 3; x++)
            {
                productos[x] = new Producto();
                Console.Write("Número producto: ");
                productos[x].CodProducto = int.Parse(Console.ReadLine());
                Console.Write("Número de marca: ");
                productos[x].CodMarca = int.Parse(Console.ReadLine());
                Console.Write("Precio: $");
                productos[x].Precio = float.Parse(Console.ReadLine());

            }

            Console.WriteLine("Cargar ventas semanales!");
            Console.WriteLine("Ingresa el número del cliente: ");
            int numCliente = int.Parse(Console.ReadLine());
            

            while (numCliente != 0)
            {
                Venta nuevaVenta = new Venta();
                nuevaVenta.CodCliente = numCliente;
                Console.Write("Ingresa el codigo del producto:");
                nuevaVenta.CodArticulo = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la cantidad vendida: ");
                nuevaVenta.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se vendio el articulo:  {nuevaVenta.CodArticulo}\nCliente:{nuevaVenta.CodCliente}\nCantidad vendida: {nuevaVenta.Cantidad}");
                Console.WriteLine("Ingresa otro numero de cliente para cargar una nueva venta o presiona 0 para salir: ");
                numCliente = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();

            










            //for(int y=0; y < 10; y++)
            //{
            //    Console.WriteLine($"Producto{productos[y].CodProducto}-----Cod. Marca: {productos[y].CodMarca} ------- precio: ${productos[y].Precio}");
            //}


        
        }
    }
}
