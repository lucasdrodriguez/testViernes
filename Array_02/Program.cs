using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_02
{
    class Program
    {
        static void Main(string[] args)
        {

            string dato;
            string[] artistas = new string[10];

            artistas[0] = "Queen";   //  qu      true 
            artistas[1] = "GNR";
            artistas[2] = "pimpinella";
            artistas[3] = "bandAna";
            artistas[4] = "TiNi";
            artistas[5] = "The Beatles";
            artistas[6] = "xUxa";
            artistas[7] = "CeratI";
            artistas[8] = "SpicE gIRLS";
            artistas[9] = "MALA fama";


            Console.WriteLine("Ingrese artista");
            dato = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Artista busco: {dato} \n\n");

            bool encontrado = false;
            string resultado = " NO ENCONTRADO ";

            for (int i = 0; i < artistas.Length; i++)
            {

                if (dato.ToLower().Trim() == artistas[i].ToLower().ToLower().Trim())
                {
                    resultado = $"Busqueda Exacta Artista encontrado: {artistas[i]}";
                    encontrado = true;
                    break;
                }
            }

            if(encontrado == false)
            {
                Console.WriteLine("NO ENCONTRADO DE FORMA EXACTA");
            }


            Console.WriteLine("\n\n");

            for (int i = 0; i < artistas.Length; i++)
            {
               
                if (artistas[i].ToLower().Trim().Contains(dato.ToLower().Trim()))
                {
                    Console.WriteLine($"BUSQUEDA PARCIAL Artista encontrado: {artistas[i]}");
                }
            }


            Console.ReadKey();
        }
    }
}
