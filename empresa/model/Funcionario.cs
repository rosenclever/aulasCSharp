using System;
namespace empresa.model
{
    public abstract class Funcionario
    {
        public string CPF { get; private set; }
        public double Salario { get; private set; }
        public static int TotalFuncionarios {get; private set;}
        public string nome { get; private set; }

        public Funcionario(string cpf)
        {
            CPF = cpf;
        }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
