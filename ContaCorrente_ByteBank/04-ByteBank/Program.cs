using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoWalter = new ContaCorrente();
            contaDoWalter.titular = "Walter Soprani";

            Console.WriteLine("Saldo : R$" + contaDoWalter.saldo);

            bool resultadoSaque = contaDoWalter.Sacar(50);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine("Saldo : R$" + contaDoWalter.saldo);


            contaDoWalter.Depositar(1000);
            Console.WriteLine("Saldo : R$" + contaDoWalter.saldo);

            Console.WriteLine();

            ContaCorrente contaDaBeatriz = new ContaCorrente();
            contaDaBeatriz.titular = "Beatriz Soprani";

            Console.WriteLine("Saldo do Walter: R$" + contaDoWalter.saldo);
            Console.WriteLine("Saldo da Beatriz: R$" + contaDaBeatriz.saldo);

            bool resultadoTransferencia = contaDoWalter.Transferir(50, contaDaBeatriz);

            Console.WriteLine("Saldo do Walter: R$" + contaDoWalter.saldo);
            Console.WriteLine("Saldo da Beatriz: R$" + contaDaBeatriz.saldo);

            Console.WriteLine("Transferência efetuada: " + resultadoTransferencia);

            resultadoTransferencia = contaDaBeatriz.Transferir(100, contaDoWalter);

            Console.WriteLine("Saldo do Walter: R$" + contaDoWalter.saldo);
            Console.WriteLine("Saldo da Beatriz: R$" + contaDaBeatriz.saldo);

            Console.WriteLine();
            Console.WriteLine("Fim da aplicação. Tecle enter para encerrar...");
            Console.Read();


        }
    }
}
