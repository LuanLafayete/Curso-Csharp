using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorDeMoedas
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double converter (double quantidade, double cotacao)
        {
            double total = cotacao * quantidade;
            return total + total * IOF / 100.00;
        }
    }
}
