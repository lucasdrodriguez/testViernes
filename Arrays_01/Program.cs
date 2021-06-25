using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LIMITE = 5;

            string[] arrayNombres = new string[LIMITE];

            arrayNombres[0] = "Lucas";
            arrayNombres[1] = "Belen";
            arrayNombres[2] = "Fernando";
            arrayNombres[3] = "Pappo";
            arrayNombres[4] = "Maria";

            string[] arrayApe = new string[LIMITE] { "Rodriguez", "Gonzalez", "Gomez", "Napolitano", "Carey" };


            Console.WriteLine("Array de nombres");

            ContarCantidadDeLetras(arrayNombres);

            Console.WriteLine();

            Console.WriteLine("Array de Apellidos");

            ContarCantidadDeLetras(arrayNombres);


            for (int i = 0; i < arrayNombres.Length; i++)
            {
                if (!string.IsNullOrEmpty(arrayNombres[i]))
                {
                    Console.WriteLine($"Alumn@ : {arrayNombres[i]}  {arrayApe[i]} ");

                }
            }


            Console.ReadKey();


        }




        static void ContarCantidadDeLetras(string[] unArray)
        {

            for (int i = 0; i < unArray.Length; i++)
            {
                Console.WriteLine(unArray[i].Length);

            }

        }



    }
}
