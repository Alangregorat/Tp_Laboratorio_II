using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string primero = "asda";
            double resu;

            if (double.TryParse(primero, out resu))
            {
                Console.WriteLine("si"+ resu);
            }
            else
            {
                Console.WriteLine("no"+ resu);
            }

            Console.ReadKey();
        }
    }
}
