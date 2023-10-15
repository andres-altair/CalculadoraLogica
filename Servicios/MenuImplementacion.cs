using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            Console.WriteLine("Bienvenido a la consola logica");
        }

        public int menuYSleccion()
        {
            int opcionseleccionada;

            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Igualdad ");
            Console.WriteLine("2. Desigualdad ");
            Console.WriteLine("#############################");
            Console.WriteLine("Seleccione una opcion: ");
            opcionseleccionada = Console.ReadKey(true).KeyChar-(0);
            return opcionseleccionada;
            if (opcionseleccionada == '1')
            {
                Console.WriteLine("Ha seleccionado la opción igualdad. Introduzca la primera expresión:");
                string a = Console.ReadLine();
                Console.WriteLine("Introduzca la segunda expresión:");
                string b = Console.ReadLine();
                if (a == b)
                {
                    Console.WriteLine("Resultado de la igualdad: true");
                }
                else { Console.WriteLine("Resultado de la igualdad: false"); }


            }
            else (opcionseleccionada == '2')
            {
                Console.WriteLine("Ha seleccionado la opción igualdad. Introduzca la primera expresión:");
                string a = Console.ReadLine();
                Console.WriteLine("Introduzca la segunda expresión:");
                string b = Console.ReadLine();
                if (a != b)
                {
                    Console.WriteLine("Resultado de la igualdad: true");
                }
                else { Console.WriteLine("Resultado de la igualdad: false"); }
            }
        }
    }
}
