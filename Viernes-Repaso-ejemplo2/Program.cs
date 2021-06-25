using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viernes_Repaso_ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polonia 
            string[] paises = { "Argentina", "Paraguay", "Rusia", null, null };
            string opcion;

            do
            {

                Console.Clear();
                Console.WriteLine("1. Ingresar nuevo pais");
                Console.WriteLine("2. Mostrar datos");
                Console.WriteLine("3. Salir");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":

                        CargarPais(paises);

                        Console.ReadKey();
                        break;

                    case "2":

                        for (int i = 0; i < paises.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(paises[i]))
                            {
                                Console.WriteLine(paises[i]);
                            }
                        }

                        Console.ReadKey();

                        break;

                    case "3":

                        break;

                    default:
                        break;
                }

            } while (opcion != "3");


        } // CIERRE MAIN

        public static void CargarPais(string[] auxPaises)
        {
            bool tengoEspacio = false;
            int espacioLibre = 0;
            string paisIngresado = "";
            string respuesta = "";

            // ver si tengo espacio o no para ingresar uno nuevo 

            for (int i = 0; i < auxPaises.Length; i++)
            {
                if (string.IsNullOrEmpty(auxPaises[i]))
                {
                    tengoEspacio = true;
                    espacioLibre = i;
                    break;
                }
            }

            //si tengo espacio:
            if (tengoEspacio == true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese pais");
                    paisIngresado = Console.ReadLine().Trim();

                    Console.WriteLine($"El pais ingresado es : {paisIngresado}");
                    Console.WriteLine("El pais es correcto? si/no/cancelar");
                    respuesta = Console.ReadLine().ToLower().Trim();
                    

                } while (respuesta == "no");

                if (respuesta == "si")
                {
                    auxPaises[espacioLibre] = paisIngresado;

                    Console.WriteLine("Pais ingresado satisfactoriamente");
                }
                else
                {
                    return;
                }
            }
            //si no tengo espacio:
            else
            {
                Console.WriteLine("No hay lugar disponible para una nueva carga");
            }
        }


    }
}
