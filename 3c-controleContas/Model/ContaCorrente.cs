using System;
namespace Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente titular) : base(titular)
        {
        }

        internal double ConsultarSaldo()
        {
            return Saldo;
        }
    }
}
