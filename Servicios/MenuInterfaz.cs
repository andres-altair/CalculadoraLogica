using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que muestra mensaje de bienvenida
        /// 151023-amd
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// metodo que mustra el menu y la seleccion del usuario
        /// </summary>
        /// <returns></returns>
        public int menuYSleccion();
    }

}
