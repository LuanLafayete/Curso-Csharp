using System;
using System.Globalization;
using System.Collections.Generic;


namespace Interdace4.NovaPasta
{
    class Funcionario : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(string cvsFuncionario)
        {
            string[] vetor = cvsFuncionario.Split(',');
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro de comparação: O argumento não é um funcionário");
            }
            Funcionario outro = obj as Funcionario;
            return Name.CompareTo(outro.Name);
        }
    }
}
