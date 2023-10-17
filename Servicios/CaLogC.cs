using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class CaLogC : CaLogI
    {
        public string deigual()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a != b)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("fase"); }
        }

        public string igual()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();  
            if (a == b)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
        }
    }
}
