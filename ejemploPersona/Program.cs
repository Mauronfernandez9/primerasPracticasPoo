using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 1;
            Persona[] personas = new Persona[cantidad];
            Console.WriteLine("Vamos a cargar 5 PERSONAS:");

            for(int x= 0; x<cantidad; x++)
            {
                
                Console.Write("Ingresa el nombre de la persona: ");
                string name = Console.ReadLine();
                Console.Write("Ingresa el apellido de la persona: ");
                string lastName = Console.ReadLine();
                Console.Write("Ingresa la nacionalidad de la persona: ");
                string nationality = Console.ReadLine();
                Console.Write("Ingresa el dni de la persona: ");
                string dni = Console.ReadLine();
                Console.Write("Ingresa el sexo de la persona: ");
                string sex = Console.ReadLine();
                Console.Write("Ingresa el año de nacimiento: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el mes de nacimiento: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el día de nacimiento: ");
                int day = int.Parse(Console.ReadLine());

                personas[x] = new Persona(name, lastName,nationality,dni,sex,year,month,day);

            }

            for(int y=0; y < cantidad; y++)
            {
                Console.WriteLine(personas[y].Saludar("ingles"));
                Console.WriteLine(personas[y].Saludar("italiano"));
                Console.WriteLine(personas[y].Saludar("Estonio"));
                Console.WriteLine(personas[y].Saludar("jaja"));
                

            }

           

            
            


        }
    }
}
