using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            int opcionElegida;
            MostrarMenu("Hola a tod@s",5);


            MostrarMenu();

            opcionElegida = IngresarEntero("Ingrese una opcion", 1, 3);


            switch (opcionElegida)
            {
                case 1:
                    edad = IngresarEntero("Ingrese edad del personaje", 0, 100);
                    Console.WriteLine(edad);


                    break;
                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }


            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Opciones");
            Console.WriteLine("3. Salir");
        }

        static void MostrarMenu(string mensaje,int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(mensaje);
            }
        }

  




        static int IngresarEntero(string mensaje, int numMin, int numMax)
        {       // devuelve     // recibe 1 , recibe 2
            int aux;

            Console.WriteLine(mensaje);

            while (!int.TryParse(Console.ReadLine(), out aux) || aux < numMin || aux > numMax)
            {
                Console.Clear();
                Console.WriteLine("Error, reingresar un valor correcto");
            }

            return aux;
        }




    }
}
