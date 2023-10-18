using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal interface CaLogI
    {/// <summary>
    /// metodo que devulve si coincide 
    /// </summary>
    /// <returns></returns>
        public void igual();

        /// <summary>
        /// metodo que devuelve que no coincide
        /// </summary>
        /// <returns></returns>
        public void deigual();

    }
}
