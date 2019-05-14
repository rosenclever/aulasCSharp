using System;

namespace Model

{
    public class ContaEspecial : Conta
    {
        private double _limite = 1000.00;
        public double Limite {
            get
            {
                return _limite;
            } 
            private set
            {
                _limite = value;
            } 
            }
        public ContaEspecial(Cliente titular, double limite) : base(titular)
        {
            Limite = limite;
            Saldo += Limite;
        }


        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public override bool Sacar(double valor)
        {
            if(valor > ConsultarSaldo())
            {
                return false;
            }
            else
            {
                base.Sacar(valor);
                return true;
            }
        }
    }
}
