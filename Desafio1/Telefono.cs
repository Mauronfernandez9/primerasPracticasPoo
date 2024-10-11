using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        /*Modelo string.
        Marca string.
        NumeroTelefonico string.
        CodigoOperador int (1, 2 o 3).
        */

        public Telefono(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
            NumeroTelefonico = "No tienes un número telefonico...";
            this.codigoOperador = 0;
            this.credito = 0;
        }

        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        private int codigoOperador;
        private int credito;

        public string Credito
        {
            get { return $"Usted tiene ${credito} de credito para llamar"; }
        }

        

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }

        }

        public string CargarCredito(int creditoACargar)
        {
            
            credito += creditoACargar;
            return "Credito cargado!";


        }



        public string Llamar()
        {
            if (credito >= 5)
            {
                credito = credito -5;
                return "Realizando llamada...";
            }
                
            else
                return "No tienes credito suficiente para realizar esta llamada...";
        }

        public string Llamar(string contacto)
        {
            if(credito >= 5)
            {
                credito = credito -5;
                return $"Llamando a {contacto}...";
            }
                
            else
                return "No tienes credito suficiente para realizar esta llamada...";

        }



    }





}

