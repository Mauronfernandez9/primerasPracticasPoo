using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPersona
{
    internal class Persona
    {
        //public Persona(string nombre, string apellido, string nacionalidad, string dni, string sexo, int añoNacimiento, int mesDeNacimiento, int diaDeNacimiento)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.nacionalidad = nacionalidad;
        //    this.dni = dni;
        //    this.sexo = sexo;
        //    this.añoNacimiento = añoNacimiento;
        //    this.mesDeNacimiento = mesDeNacimiento;
        //    this.diaDeNacimiento = diaDeNacimiento;
        //}


        public string Nombre { get; }
        public string Apellido { get; }
        public string Nacionalidad { get; }
        public string Dni { get; }
        public string Sexo { get; }
        public int AñoNacimiento { get; }
        public int MesNacimiento { get; }
        public int DiaNacimiento { get; }

        private int edad;

        public Persona(string nombre, string apellido, string nac, string dni, string sex, int añoNac, int mesNac, int diaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nac;
            Dni = dni;
            Sexo = sex;
            AñoNacimiento = añoNac;
            MesNacimiento = mesNac;
            DiaNacimiento = diaNac;
        }

        public string Saludar()
        {
            return "Hola soy " + Nombre;
        }
        public string Saludar(string idioma)
        {
            idioma = idioma.ToLower();
            if (idioma == "ingles")
                return "Hi there! I'm " + Nombre;


            else if (idioma == "italiano")
                return "Ciao! Io sono " + Nombre;
            else if (idioma == "estonio")
                return "Tere! Ma olen " + Nombre;
            else
                return "Hola mi nombre es " + Nombre;
        }

        public string DecirEdad()
        {
            int añoActual = 2024;
            int mesActual = 9;
            int diaActual = 18;
            if (MesNacimiento <= mesActual)
            {
                edad = añoActual - AñoNacimiento;
            }
            else if (MesNacimiento == mesActual)
            {
                if (DiaNacimiento <= diaActual)
                    edad = añoActual - AñoNacimiento;
                else
                    edad = añoActual - AñoNacimiento - 1;
            }
            else
                edad = añoActual - AñoNacimiento - 1;

            return $"Mi edad es  {edad}";



        }




        //private string nombre, apellido, nacionalidad, sexo, dni;
        //private int añoNacimiento, mesDeNacimiento, diaDeNacimiento, edad;


        //public int Edad
        //{
        //    get { return edad; }
        //}


        //public string Saludar()
        //{
        //    return $"Hola soy {nombre}";
        //}

        //public string DecirEdad()
        //{
        //    int mesActual = 9;
        //    int añoActual = 2024;
        //    int diaActual = 18;

        //    if (mesDeNacimiento < mesActual)
        //    {
        //        edad = añoActual - añoNacimiento;

        //    }
        //    else if (mesDeNacimiento == mesActual)
        //    {
        //        if (diaDeNacimiento <= diaActual)
        //        {
        //            edad = añoActual - añoNacimiento;
        //        }
        //        else
        //            edad = añoActual - añoNacimiento - 1;
        //    }
        //    else
        //        edad = añoActual - añoNacimiento - 1;



        //    return $"La edad de la persona es: {edad}";
        //}




    }
}
