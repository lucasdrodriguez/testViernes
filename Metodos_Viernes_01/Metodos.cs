using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Viernes_01
{
    class Metodos
    {


        public static void Menu1(int cantidad, string mensaje)
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{mensaje} {i + 1} ");
            }

        }



    }
}
