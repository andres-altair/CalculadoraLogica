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
            
            
        }
    }
}
