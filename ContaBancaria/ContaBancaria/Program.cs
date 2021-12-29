using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inical (s/n)?");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Valor do deposito: ");
                double depInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, nome, depInicial);
            }
            else
            {
                conta = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Valor de depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Valor de saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
    
}
