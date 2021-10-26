using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorDeMoeda03
{
    class ConvertorDeMoeda
    {
        public double IOF = 6.0;

        public double Converter(double Dolar, double Quantidade)
        {
            double total = Dolar * Quantidade;
            return total + total * IOF / 100;
        }
    }
}
