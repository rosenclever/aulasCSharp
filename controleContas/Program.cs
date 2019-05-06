using System;
using empresa;

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(10.00);
            conta1.Numero = 654321;
            conta1.Saldo = 2341.42;

            Cliente cliente1 = new Cliente("Caio", "10987654321");
            //conta1.Titular = cliente1;

            Conta conta2 = new Conta( new Cliente("Guilherme", "12345678901"));
            conta2.Numero = 10000;
            conta2.Saldo = 42420.00;
            conta2.Titular.Nome = "Guilherme";


            Console.WriteLine("Saldo da conta1: {0}", conta1.Saldo);
            Console.WriteLine("Saldo da conta2: " + conta2.Saldo);

            Console.WriteLine("Titular da conta 2: {0}", conta2.Titular.Nome);

            Console.WriteLine("Saldo disponível: {0}", conta2.Saldo);
            if (conta2.Sacar(100))
            {
                Console.WriteLine("Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque" +
                "solicitado.");

            }
            Console.WriteLine("Conta 2 - Saldo disponível: {0}", conta2.Saldo);
            Console.WriteLine("Conta 1 - Saldo disponível: {0}", conta1.Saldo);
            Console.WriteLine("******* Transferindo.......");
            conta2.Transferir(conta1, 1000);
            Console.WriteLine("Conta 2 - Saldo disponível: {0}", conta2.Saldo);
            Console.WriteLine("Conta 1 - Saldo disponível: {0}", conta1.Saldo);

            Console.ReadLine();
        }
    }
}
