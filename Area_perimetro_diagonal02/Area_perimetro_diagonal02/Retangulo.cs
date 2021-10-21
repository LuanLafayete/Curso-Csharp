using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Area_perimetro_diagonal02
{
    class Retangulo
    {
        public double largura;
        public double altura;


        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return 2 * altura + 2 * largura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(largura, 2.0));
        }
    }    
}
