using System;
namespace Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente titular) : base(titular)
        {

        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        internal double ConsultarSaldo()
        {
            return Saldo;
        }
    }
}
