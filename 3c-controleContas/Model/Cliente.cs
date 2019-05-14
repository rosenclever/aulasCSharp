using System;
namespace Model

{
    public class Cliente
    {
        private string _cpf;
        private int _anoNascimento;

        public string Email { get; set; }



        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;

        }

        public int anoNascimento
        {
            get
            {
                return _anoNascimento;
            }
            set
            {
                if ((2019 - value) >= 18)
                    _anoNascimento = value;
                else
                    Console.WriteLine("O cliente deve ter mais de 18 anos");
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if(value.Length == 11)
                {
                    _cpf = value;
                }
                else
                    Console.WriteLine("O CPF deve possuir 11 digitos.");
            }
        }

        public string Nome { get; set; }
    }
}
