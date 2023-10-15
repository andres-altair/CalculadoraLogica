using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class CaLogC : caLog
    {
        int opcionSeleccionada = Console.ReadLine(true);
         if (opcionSeleccionada == '1')
            {
                Console.WriteLine("Ha seleccionado la opción igualdad. Introduzca la primera expresión:");
                string a = Console.ReadLine();
                Console.WriteLine("Introduzca la segunda expresión:");
                string b = Console.ReadLine();
                if (a == b)
                {
                    Console.WriteLine("Resultado de la igualdad: true");
                }
                else

            }
    }
}
