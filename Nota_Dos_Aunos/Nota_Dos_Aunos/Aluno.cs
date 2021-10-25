using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Nota_Dos_Aunos
{
    class Aluno
    {
        public string nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }       
       
    }
}
