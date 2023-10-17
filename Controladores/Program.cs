using CalculadoraLogica.Servicios;
using System;
namespace CalculadoraLogica.Controladores
{
    class CalculadoraLogica
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            CaLogI ci = new CaLogC();
            mi.mensajeBienvenida();

            bool cerrarMenu = false;
            int opcionseleccionar;
            while (!cerrarMenu)
            {
                opcionseleccionar = mi.menuYSleccion();
                Console.WriteLine(opcionseleccionar);

                switch (opcionseleccionar)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        ci.igual();

                        break;
                    case 2:
                        ci.deigual();
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }


            }

        }
            



    }
}