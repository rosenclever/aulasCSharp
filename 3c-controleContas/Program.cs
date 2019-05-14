using System;
using Model;

namespace controleBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente ana = new Cliente("Ana Júlia", "12345678901");
            ContaEspecial contaEspecial = new ContaEspecial(ana, 1000);
            ContaCorrente contaComum = new ContaCorrente(new Cliente("Paulo", "10987654321"));

            contaEspecial.Depositar(555);
            contaComum.Depositar(555);

            Console.WriteLine("Saldo da conta especial: " +  contaEspecial.ConsultarSaldo());
            Console.WriteLine("Saldo da conta comum: " + contaComum.ConsultarSaldo());

            if (contaEspecial.Sacar(1000))
            {
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saque não realizado!");
            }
            Console.WriteLine("Saldo da conta especial: " + contaEspecial.ConsultarSaldo());

            if (contaComum.Sacar(1000))
            {
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saque não realizado!");
            }
            Console.WriteLine("Saldo da conta comum: " + contaComum.ConsultarSaldo());

            Console.ReadLine();
        }
    }
}
