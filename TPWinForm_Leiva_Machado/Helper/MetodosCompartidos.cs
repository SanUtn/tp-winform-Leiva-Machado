using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Helper
{
    public class MetodosCompartidos
    {
        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter))) return false;
            }
            return true;
        }

        public bool soloLetrasYNumeros(string cadena)
        {
            bool bandera = false;
            foreach (char caracter in cadena)
            {
                bandera = false;
                if (char.IsLetter(caracter) || char.IsNumber(caracter)) 
                    bandera = true;
                     
            }
            return bandera;
        }


    }
}
