using System;
namespace controleBancario
{
    public class Conta
    {
        private long _numero;
        protected double Saldo { get; set; }
        protected Cliente Titular { get; set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public Conta(Cliente titular)
        {
            Titular = titular;
        }

        public long Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value >= 1000)
                    _numero = value;
                else
                    Console.WriteLine("O número da conta " +
                    	"deve ser superior a 1000");

            }
        }


        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            valor += 0.10;
            if(Saldo > valor)
            {
                Saldo -= valor;
                return true;
            }
            else
            { 
                return false;
            }
        }

        public bool Transferir(Conta destino, double valor)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            else
                return false;
        }
    }
}
