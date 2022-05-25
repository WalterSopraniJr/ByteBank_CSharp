using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente willian = new Cliente();
            //willian.nome = "Willian Soprani";
            //willian.profissao = "Auditor";
            //willian.cpf = "111.111.11-11";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = willian;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Willian Soprani";
            //conta.titular.cpf = "111.111.11-11";
            //conta.titular.profissao = "Auditor";

            conta.saldo = 1000;
            conta.agencia = 386;
            conta.numero = 386386;

            if(conta.titular == null)
            {
                Console.WriteLine("A referência em conta.titular é NULL");
            }

            //Console.WriteLine(willian.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.profissao);
            //Console.WriteLine(conta.titular.cpf);

            Console.Read();
        }
    }
}
