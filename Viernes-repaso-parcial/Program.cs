using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viernes_repaso_parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            string palabra = "Juan Pablo";
            palabra = "";
            palabra = null;

            if (!string.IsNullOrEmpty(palabra))
            {

                bool resultado = IsAllLetters(palabra);

                if (resultado)
                {
                    Console.WriteLine("Es verdadero: tiene solo letras");
                }
                else
                {
                    Console.WriteLine("Es falso: tiene al menos un numero");
                }

            }
            Console.ReadKey();
        }


        public static bool IsAllLetters(string auxPalabra)
        {
            // HOLA    H O L A 
            foreach (char letra in auxPalabra)
            {
                if (!Char.IsLetter(letra) && !char.IsWhiteSpace(letra))
                    return false;
            }
            return true;
        }
    }
}
