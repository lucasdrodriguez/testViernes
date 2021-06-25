using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Viernes_01
{
    class Validaciones
    {



        // sobrecarga de metodos
        public static int ContarCantidadLetras(string palabra)
        {
            return palabra.Length;
        }

        public static int ContarCantidadLetras(string[] arrayDePalabras)
        {

            int acumulador = 0;

            for (int i = 0; i < arrayDePalabras.Length; i++)
            {
                if (!string.IsNullOrEmpty(arrayDePalabras[i]))
                {
                    acumulador += ContarCantidadLetras(arrayDePalabras[i]);
                }
            }
            return acumulador;
        }


    }
}
