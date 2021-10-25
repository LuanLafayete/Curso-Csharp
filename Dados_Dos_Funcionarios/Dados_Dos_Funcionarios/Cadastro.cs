using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dados_Dos_Funcionarios
{
    class Cadastro
    {
        public string nome;
        public double Sal;
        public double Imposto;

        public double Liquido()
        {
            return Sal - Imposto;
        }
        
        public void AumentarSalario(double porcentagem)
        {
            Sal = Sal + (Sal * porcentagem / 100.0);
        }



        public override string ToString()
        {
            return "Funcionário: "
                + nome
                + ", $"
                + Liquido();

        }
    }
}
