using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "Walter Soprani";
            cliente.CPF = "222.222.222-22";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;


            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.CPF);
            Console.WriteLine(cliente.Profissao);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
