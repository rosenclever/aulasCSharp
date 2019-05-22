using System;
namespace Model
{
    public abstract class Conta
    {
        private long _numero;

        public static  int TotalContas { get; protected set; }

        protected double Saldo { get; set; }
        protected Cliente Titular { get; set; }

        public Conta(Cliente titular)
        {
            Titular = titular;
            Saldo = 10.0;
            TotalContas++;
        }

        public Conta(Cliente titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
            TotalContas++;
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


        public abstract void Depositar(double valor);

        public virtual bool Sacar(double valor)
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
