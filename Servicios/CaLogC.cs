using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class CaLogC : CaLogI
    {
        public void deigual()
        {
            Console.WriteLine("Escribe una palabra");
            string a = Console.ReadLine();
            Console.WriteLine("Escribe una palabra");
            string b = Console.ReadLine();
            if (a != b)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("fase"); }
        }

        public void igual()
        {
            Console.WriteLine("Escribe una palabra");
            string a = Console.ReadLine();
            Console.WriteLine("Escribe una palabra");
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
        }
    }
}
