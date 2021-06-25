using System;

namespace Metodos_Viernes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantiLetras;
            string[] arrayPalab = { "pepe", "carolina", "juana", "polonia", "chocolate" };


            Metodos.Menu1(5, "opcion");

            Console.WriteLine("-----------");

            Metodos.Menu1(10, "cantidad de ventas");

           


            Console.WriteLine("-----------");

            cantiLetras = Validaciones.ContarCantidadLetras("pepe");
            Console.WriteLine(cantiLetras);

            cantiLetras = Validaciones.ContarCantidadLetras(arrayPalab);
            Console.WriteLine(cantiLetras);


            Console.ReadKey();

        }
        // parametro
       


        static void ConvertirADouble()
        {

            double.Parse("b");
        }
        static void ConvertirAInt()
        {

            int.Parse("b");
        }
    }
}
